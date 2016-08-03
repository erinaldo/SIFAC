<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaBuscarFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaBuscarFactura))
        Me.grpDatos = New System.Windows.Forms.GroupBox
        Me.cmbCliente = New C1.Win.C1List.C1Combo
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.dtpHasta = New C1.Win.C1Input.C1DateEdit
        Me.dtpDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ErrorBusquedaFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDatos.SuspendLayout()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo.SuspendLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorBusquedaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.cmbCliente)
        Me.grpDatos.Controls.Add(Me.cmbSucursal)
        Me.grpDatos.Controls.Add(Me.txtNumeroFactura)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Location = New System.Drawing.Point(12, 38)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(363, 112)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Generales"
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
        Me.cmbCliente.Location = New System.Drawing.Point(107, 77)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(229, 21)
        Me.cmbCliente.TabIndex = 5
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
        Me.cmbSucursal.Location = New System.Drawing.Point(107, 50)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(229, 21)
        Me.cmbSucursal.TabIndex = 4
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(107, 22)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroFactura.TabIndex = 3
        Me.txtNumeroFactura.Text = "TODAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Factura:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(593, 157)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(512, 157)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.dtpHasta)
        Me.grpPeriodo.Controls.Add(Me.dtpDesde)
        Me.grpPeriodo.Controls.Add(Me.Label5)
        Me.grpPeriodo.Controls.Add(Me.Label4)
        Me.grpPeriodo.Location = New System.Drawing.Point(388, 38)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(280, 111)
        Me.grpPeriodo.TabIndex = 3
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período Factura"
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
        Me.dtpHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpHasta.Location = New System.Drawing.Point(96, 59)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(159, 20)
        Me.dtpHasta.TabIndex = 4
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
        Me.dtpDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpDesde.Location = New System.Drawing.Point(96, 33)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(159, 20)
        Me.dtpDesde.TabIndex = 3
        Me.dtpDesde.Tag = Nothing
        Me.dtpDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Desde:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(606, -1)
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
        Me.Panel2.Size = New System.Drawing.Size(679, 32)
        Me.Panel2.TabIndex = 30
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 21)
        Me.Panel1.TabIndex = 49
        '
        'ErrorBusquedaFactura
        '
        Me.ErrorBusquedaFactura.ContainerControl = Me
        '
        'frmSfaBuscarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 215)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.grpDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaBuscarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Factura"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorBusquedaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents dtpHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorBusquedaFactura As System.Windows.Forms.ErrorProvider
End Class
