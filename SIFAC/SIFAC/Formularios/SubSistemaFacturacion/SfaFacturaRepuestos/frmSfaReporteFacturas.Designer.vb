<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaReporteFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaReporteFacturas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpSucursal = New System.Windows.Forms.GroupBox
        Me.cmbVendedor = New C1.Win.C1List.C1Combo
        Me.cmbCliente = New C1.Win.C1List.C1Combo
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpTerminoPago = New System.Windows.Forms.GroupBox
        Me.rbTodasPago = New System.Windows.Forms.RadioButton
        Me.rbFacturaContado = New System.Windows.Forms.RadioButton
        Me.rbCredito = New System.Windows.Forms.RadioButton
        Me.grpIVA = New System.Windows.Forms.GroupBox
        Me.rbTodasIVA = New System.Windows.Forms.RadioButton
        Me.rbExonerado = New System.Windows.Forms.RadioButton
        Me.rbGravado = New System.Windows.Forms.RadioButton
        Me.grbRangoFecha = New System.Windows.Forms.GroupBox
        Me.dtpHasta = New C1.Win.C1Input.C1DateEdit
        Me.dtpDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ErrorImprimirFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.grpSucursal.SuspendLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTerminoPago.SuspendLayout()
        Me.grpIVA.SuspendLayout()
        Me.grbRangoFecha.SuspendLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorImprimirFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(558, -1)
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
        Me.Panel2.Size = New System.Drawing.Size(630, 32)
        Me.Panel2.TabIndex = 32
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 21)
        Me.Panel1.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Seleccione criterios para su reporte:"
        '
        'grpSucursal
        '
        Me.grpSucursal.Controls.Add(Me.cmbVendedor)
        Me.grpSucursal.Controls.Add(Me.cmbCliente)
        Me.grpSucursal.Controls.Add(Me.cmbSucursal)
        Me.grpSucursal.Controls.Add(Me.Label4)
        Me.grpSucursal.Controls.Add(Me.Label3)
        Me.grpSucursal.Controls.Add(Me.Label2)
        Me.grpSucursal.Location = New System.Drawing.Point(15, 65)
        Me.grpSucursal.Name = "grpSucursal"
        Me.grpSucursal.Size = New System.Drawing.Size(312, 120)
        Me.grpSucursal.TabIndex = 53
        Me.grpSucursal.TabStop = False
        '
        'cmbVendedor
        '
        Me.cmbVendedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbVendedor.Caption = ""
        Me.cmbVendedor.CaptionHeight = 17
        Me.cmbVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbVendedor.ColumnCaptionHeight = 17
        Me.cmbVendedor.ColumnFooterHeight = 17
        Me.cmbVendedor.ColumnHeaders = False
        Me.cmbVendedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbVendedor.ContentHeight = 15
        Me.cmbVendedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVendedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVendedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVendedor.EditorHeight = 15
        Me.cmbVendedor.Images.Add(CType(resources.GetObject("cmbVendedor.Images"), System.Drawing.Image))
        Me.cmbVendedor.ItemHeight = 15
        Me.cmbVendedor.Location = New System.Drawing.Point(90, 80)
        Me.cmbVendedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVendedor.MaxDropDownItems = CType(5, Short)
        Me.cmbVendedor.MaxLength = 32767
        Me.cmbVendedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbVendedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVendedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVendedor.Size = New System.Drawing.Size(191, 21)
        Me.cmbVendedor.TabIndex = 12
        Me.cmbVendedor.PropBag = resources.GetString("cmbVendedor.PropBag")
        '
        'cmbCliente
        '
        Me.cmbCliente.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCliente.Caption = ""
        Me.cmbCliente.CaptionHeight = 17
        Me.cmbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCliente.ColumnCaptionHeight = 17
        Me.cmbCliente.ColumnFooterHeight = 17
        Me.cmbCliente.ColumnHeaders = False
        Me.cmbCliente.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCliente.ContentHeight = 15
        Me.cmbCliente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCliente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCliente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCliente.EditorHeight = 15
        Me.cmbCliente.Images.Add(CType(resources.GetObject("cmbCliente.Images"), System.Drawing.Image))
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(90, 50)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(191, 21)
        Me.cmbCliente.TabIndex = 11
        Me.cmbCliente.PropBag = resources.GetString("cmbCliente.PropBag")
        '
        'cmbSucursal
        '
        Me.cmbSucursal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursal.Caption = ""
        Me.cmbSucursal.CaptionHeight = 17
        Me.cmbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursal.ColumnCaptionHeight = 17
        Me.cmbSucursal.ColumnFooterHeight = 17
        Me.cmbSucursal.ColumnHeaders = False
        Me.cmbSucursal.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSucursal.ContentHeight = 15
        Me.cmbSucursal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.Location = New System.Drawing.Point(90, 21)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(191, 21)
        Me.cmbSucursal.TabIndex = 4
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Susursal"
        '
        'grpTerminoPago
        '
        Me.grpTerminoPago.Controls.Add(Me.rbTodasPago)
        Me.grpTerminoPago.Controls.Add(Me.rbFacturaContado)
        Me.grpTerminoPago.Controls.Add(Me.rbCredito)
        Me.grpTerminoPago.Location = New System.Drawing.Point(15, 202)
        Me.grpTerminoPago.Name = "grpTerminoPago"
        Me.grpTerminoPago.Size = New System.Drawing.Size(169, 101)
        Me.grpTerminoPago.TabIndex = 54
        Me.grpTerminoPago.TabStop = False
        Me.grpTerminoPago.Text = "Término de pago"
        '
        'rbTodasPago
        '
        Me.rbTodasPago.AutoSize = True
        Me.rbTodasPago.Checked = True
        Me.rbTodasPago.Location = New System.Drawing.Point(10, 73)
        Me.rbTodasPago.Name = "rbTodasPago"
        Me.rbTodasPago.Size = New System.Drawing.Size(55, 17)
        Me.rbTodasPago.TabIndex = 2
        Me.rbTodasPago.TabStop = True
        Me.rbTodasPago.Text = "Todas"
        Me.rbTodasPago.UseVisualStyleBackColor = True
        '
        'rbFacturaContado
        '
        Me.rbFacturaContado.AutoSize = True
        Me.rbFacturaContado.Location = New System.Drawing.Point(10, 50)
        Me.rbFacturaContado.Name = "rbFacturaContado"
        Me.rbFacturaContado.Size = New System.Drawing.Size(109, 17)
        Me.rbFacturaContado.TabIndex = 1
        Me.rbFacturaContado.TabStop = True
        Me.rbFacturaContado.Text = "Facturas Contado"
        Me.rbFacturaContado.UseVisualStyleBackColor = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(10, 27)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(102, 17)
        Me.rbCredito.TabIndex = 0
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Facturas Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'grpIVA
        '
        Me.grpIVA.Controls.Add(Me.rbTodasIVA)
        Me.grpIVA.Controls.Add(Me.rbExonerado)
        Me.grpIVA.Controls.Add(Me.rbGravado)
        Me.grpIVA.Location = New System.Drawing.Point(190, 202)
        Me.grpIVA.Name = "grpIVA"
        Me.grpIVA.Size = New System.Drawing.Size(137, 101)
        Me.grpIVA.TabIndex = 55
        Me.grpIVA.TabStop = False
        Me.grpIVA.Text = "IVA"
        '
        'rbTodasIVA
        '
        Me.rbTodasIVA.AutoSize = True
        Me.rbTodasIVA.Checked = True
        Me.rbTodasIVA.Location = New System.Drawing.Point(20, 71)
        Me.rbTodasIVA.Name = "rbTodasIVA"
        Me.rbTodasIVA.Size = New System.Drawing.Size(55, 17)
        Me.rbTodasIVA.TabIndex = 2
        Me.rbTodasIVA.TabStop = True
        Me.rbTodasIVA.Text = "Todas"
        Me.rbTodasIVA.UseVisualStyleBackColor = True
        '
        'rbExonerado
        '
        Me.rbExonerado.AutoSize = True
        Me.rbExonerado.Location = New System.Drawing.Point(20, 48)
        Me.rbExonerado.Name = "rbExonerado"
        Me.rbExonerado.Size = New System.Drawing.Size(76, 17)
        Me.rbExonerado.TabIndex = 1
        Me.rbExonerado.TabStop = True
        Me.rbExonerado.Text = "Exonerado"
        Me.rbExonerado.UseVisualStyleBackColor = True
        '
        'rbGravado
        '
        Me.rbGravado.AutoSize = True
        Me.rbGravado.Location = New System.Drawing.Point(20, 25)
        Me.rbGravado.Name = "rbGravado"
        Me.rbGravado.Size = New System.Drawing.Size(66, 17)
        Me.rbGravado.TabIndex = 0
        Me.rbGravado.TabStop = True
        Me.rbGravado.Text = "Gravado"
        Me.rbGravado.UseVisualStyleBackColor = True
        '
        'grbRangoFecha
        '
        Me.grbRangoFecha.Controls.Add(Me.dtpHasta)
        Me.grbRangoFecha.Controls.Add(Me.dtpDesde)
        Me.grbRangoFecha.Controls.Add(Me.Label6)
        Me.grbRangoFecha.Controls.Add(Me.Label5)
        Me.grbRangoFecha.Location = New System.Drawing.Point(342, 66)
        Me.grbRangoFecha.Name = "grbRangoFecha"
        Me.grbRangoFecha.Size = New System.Drawing.Size(269, 119)
        Me.grbRangoFecha.TabIndex = 56
        Me.grbRangoFecha.TabStop = False
        '
        'dtpHasta
        '
        Me.dtpHasta.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpHasta.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpHasta.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpHasta.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpHasta.Location = New System.Drawing.Point(75, 55)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(176, 20)
        Me.dtpHasta.TabIndex = 3
        Me.dtpHasta.Tag = Nothing
        Me.dtpHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpDesde
        '
        Me.dtpDesde.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpDesde.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpDesde.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpDesde.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpDesde.Location = New System.Drawing.Point(75, 20)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(176, 20)
        Me.dtpDesde.TabIndex = 2
        Me.dtpDesde.Tag = Nothing
        Me.dtpDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Hasta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Desde:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(448, 275)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 57
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(537, 275)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 58
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'ErrorImprimirFactura
        '
        Me.ErrorImprimirFactura.ContainerControl = Me
        '
        'frmSfaReporteFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 347)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grbRangoFecha)
        Me.Controls.Add(Me.grpIVA)
        Me.Controls.Add(Me.grpTerminoPago)
        Me.Controls.Add(Me.grpSucursal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaReporteFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir reporte de facturas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.grpSucursal.ResumeLayout(False)
        Me.grpSucursal.PerformLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTerminoPago.ResumeLayout(False)
        Me.grpTerminoPago.PerformLayout()
        Me.grpIVA.ResumeLayout(False)
        Me.grpIVA.PerformLayout()
        Me.grbRangoFecha.ResumeLayout(False)
        Me.grbRangoFecha.PerformLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorImprimirFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpSucursal As System.Windows.Forms.GroupBox
    Friend WithEvents grpTerminoPago As System.Windows.Forms.GroupBox
    Friend WithEvents grpIVA As System.Windows.Forms.GroupBox
    Friend WithEvents grbRangoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents rbTodasPago As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturaContado As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodasIVA As System.Windows.Forms.RadioButton
    Friend WithEvents rbExonerado As System.Windows.Forms.RadioButton
    Friend WithEvents rbGravado As System.Windows.Forms.RadioButton
    Friend WithEvents dtpHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorImprimirFactura As System.Windows.Forms.ErrorProvider
End Class
