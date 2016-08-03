<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditTramiteLegal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditTramiteLegal))
        Me.gbxDatos = New System.Windows.Forms.GroupBox
        Me.txtSaldoCuenta = New System.Windows.Forms.TextBox
        Me.lblSaldoFecha = New System.Windows.Forms.Label
        Me.txtComentario = New System.Windows.Forms.TextBox
        Me.lblComentarios = New System.Windows.Forms.Label
        Me.lblEntregadoa = New System.Windows.Forms.Label
        Me.cmbEmpleados = New C1.Win.C1List.C1Combo
        Me.cmbExpedientes = New C1.Win.C1List.C1Combo
        Me.lblExpediente = New System.Windows.Forms.Label
        Me.cmbClientes = New C1.Win.C1List.C1Combo
        Me.lblCliente = New System.Windows.Forms.Label
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit
        Me.lblFechaPedido = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.lblNumeroEntrega = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblInfo = New System.Windows.Forms.Label
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.gbxDatos.SuspendLayout()
        CType(Me.cmbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.txtSaldoCuenta)
        Me.gbxDatos.Controls.Add(Me.lblSaldoFecha)
        Me.gbxDatos.Controls.Add(Me.txtComentario)
        Me.gbxDatos.Controls.Add(Me.lblComentarios)
        Me.gbxDatos.Controls.Add(Me.lblEntregadoa)
        Me.gbxDatos.Controls.Add(Me.cmbEmpleados)
        Me.gbxDatos.Controls.Add(Me.cmbExpedientes)
        Me.gbxDatos.Controls.Add(Me.lblExpediente)
        Me.gbxDatos.Controls.Add(Me.cmbClientes)
        Me.gbxDatos.Controls.Add(Me.lblCliente)
        Me.gbxDatos.Controls.Add(Me.dtpFecha)
        Me.gbxDatos.Controls.Add(Me.lblFechaPedido)
        Me.gbxDatos.Controls.Add(Me.txtNumero)
        Me.gbxDatos.Controls.Add(Me.lblNumeroEntrega)
        Me.gbxDatos.Location = New System.Drawing.Point(10, 38)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(649, 246)
        Me.gbxDatos.TabIndex = 1
        Me.gbxDatos.TabStop = False
        '
        'txtSaldoCuenta
        '
        Me.txtSaldoCuenta.Enabled = False
        Me.txtSaldoCuenta.Location = New System.Drawing.Point(481, 84)
        Me.txtSaldoCuenta.Name = "txtSaldoCuenta"
        Me.txtSaldoCuenta.Size = New System.Drawing.Size(147, 20)
        Me.txtSaldoCuenta.TabIndex = 95
        Me.txtSaldoCuenta.Tag = "BLOQUEADO"
        '
        'lblSaldoFecha
        '
        Me.lblSaldoFecha.AutoSize = True
        Me.lblSaldoFecha.Location = New System.Drawing.Point(394, 87)
        Me.lblSaldoFecha.Name = "lblSaldoFecha"
        Me.lblSaldoFecha.Size = New System.Drawing.Size(87, 13)
        Me.lblSaldoFecha.TabIndex = 94
        Me.lblSaldoFecha.Tag = ""
        Me.lblSaldoFecha.Text = "Saldo a la fecha:"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(89, 152)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(542, 77)
        Me.txtComentario.TabIndex = 93
        '
        'lblComentarios
        '
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.Location = New System.Drawing.Point(12, 155)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(68, 13)
        Me.lblComentarios.TabIndex = 92
        Me.lblComentarios.Tag = ""
        Me.lblComentarios.Text = "Comentarios:"
        '
        'lblEntregadoa
        '
        Me.lblEntregadoa.AutoSize = True
        Me.lblEntregadoa.Location = New System.Drawing.Point(12, 120)
        Me.lblEntregadoa.Name = "lblEntregadoa"
        Me.lblEntregadoa.Size = New System.Drawing.Size(68, 13)
        Me.lblEntregadoa.TabIndex = 91
        Me.lblEntregadoa.Tag = ""
        Me.lblEntregadoa.Text = "Entregado a:"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEmpleados.AutoCompletion = True
        Me.cmbEmpleados.Caption = ""
        Me.cmbEmpleados.CaptionHeight = 17
        Me.cmbEmpleados.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEmpleados.ColumnCaptionHeight = 17
        Me.cmbEmpleados.ColumnFooterHeight = 17
        Me.cmbEmpleados.ContentHeight = 15
        Me.cmbEmpleados.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEmpleados.DropDownWidth = 297
        Me.cmbEmpleados.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEmpleados.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleados.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEmpleados.EditorHeight = 15
        Me.cmbEmpleados.Images.Add(CType(resources.GetObject("cmbEmpleados.Images"), System.Drawing.Image))
        Me.cmbEmpleados.ItemHeight = 15
        Me.cmbEmpleados.LimitToList = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(89, 116)
        Me.cmbEmpleados.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEmpleados.MaxDropDownItems = CType(5, Short)
        Me.cmbEmpleados.MaxLength = 32767
        Me.cmbEmpleados.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEmpleados.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEmpleados.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEmpleados.Size = New System.Drawing.Size(297, 21)
        Me.cmbEmpleados.TabIndex = 90
        Me.cmbEmpleados.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbEmpleados.PropBag = resources.GetString("cmbEmpleados.PropBag")
        '
        'cmbExpedientes
        '
        Me.cmbExpedientes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbExpedientes.AutoCompletion = True
        Me.cmbExpedientes.Caption = ""
        Me.cmbExpedientes.CaptionHeight = 17
        Me.cmbExpedientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbExpedientes.ColumnCaptionHeight = 17
        Me.cmbExpedientes.ColumnFooterHeight = 17
        Me.cmbExpedientes.ContentHeight = 15
        Me.cmbExpedientes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbExpedientes.DropDownWidth = 160
        Me.cmbExpedientes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbExpedientes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpedientes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbExpedientes.EditorHeight = 15
        Me.cmbExpedientes.Images.Add(CType(resources.GetObject("cmbExpedientes.Images"), System.Drawing.Image))
        Me.cmbExpedientes.ItemHeight = 15
        Me.cmbExpedientes.LimitToList = True
        Me.cmbExpedientes.Location = New System.Drawing.Point(89, 51)
        Me.cmbExpedientes.MatchEntryTimeout = CType(2000, Long)
        Me.cmbExpedientes.MaxDropDownItems = CType(5, Short)
        Me.cmbExpedientes.MaxLength = 32767
        Me.cmbExpedientes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbExpedientes.Name = "cmbExpedientes"
        Me.cmbExpedientes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbExpedientes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbExpedientes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbExpedientes.Size = New System.Drawing.Size(160, 21)
        Me.cmbExpedientes.TabIndex = 89
        Me.cmbExpedientes.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbExpedientes.PropBag = resources.GetString("cmbExpedientes.PropBag")
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Location = New System.Drawing.Point(12, 52)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(63, 13)
        Me.lblExpediente.TabIndex = 88
        Me.lblExpediente.Tag = ""
        Me.lblExpediente.Text = "Expediente:"
        '
        'cmbClientes
        '
        Me.cmbClientes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClientes.AutoCompletion = True
        Me.cmbClientes.Caption = ""
        Me.cmbClientes.CaptionHeight = 17
        Me.cmbClientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClientes.ColumnCaptionHeight = 17
        Me.cmbClientes.ColumnFooterHeight = 17
        Me.cmbClientes.ContentHeight = 15
        Me.cmbClientes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClientes.DropDownWidth = 297
        Me.cmbClientes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClientes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClientes.EditorHeight = 15
        Me.cmbClientes.Images.Add(CType(resources.GetObject("cmbClientes.Images"), System.Drawing.Image))
        Me.cmbClientes.ItemHeight = 15
        Me.cmbClientes.LimitToList = True
        Me.cmbClientes.Location = New System.Drawing.Point(89, 81)
        Me.cmbClientes.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClientes.MaxDropDownItems = CType(5, Short)
        Me.cmbClientes.MaxLength = 32767
        Me.cmbClientes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClientes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClientes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClientes.Size = New System.Drawing.Size(297, 21)
        Me.cmbClientes.TabIndex = 87
        Me.cmbClientes.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbClientes.PropBag = resources.GetString("cmbClientes.PropBag")
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 88)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 86
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpFecha
        '
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(477, 23)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(154, 20)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.AutoSize = True
        Me.lblFechaPedido.Location = New System.Drawing.Point(396, 27)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaPedido.TabIndex = 42
        Me.lblFechaPedido.Tag = "OBLIGATORIO"
        Me.lblFechaPedido.Text = "Fecha:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(89, 19)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(157, 20)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'lblNumeroEntrega
        '
        Me.lblNumeroEntrega.AutoSize = True
        Me.lblNumeroEntrega.Location = New System.Drawing.Point(12, 24)
        Me.lblNumeroEntrega.Name = "lblNumeroEntrega"
        Me.lblNumeroEntrega.Size = New System.Drawing.Size(67, 13)
        Me.lblNumeroEntrega.TabIndex = 19
        Me.lblNumeroEntrega.Tag = ""
        Me.lblNumeroEntrega.Text = "No. Entrega:"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(588, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
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
        Me.Panel2.Size = New System.Drawing.Size(670, 32)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Tag = "LAYOUT"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(584, 297)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(503, 298)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 22)
        Me.Panel1.TabIndex = 11
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(10, 289)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(108, 13)
        Me.lblInfo.TabIndex = 71
        Me.lblInfo.Tag = ""
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.Shadow = False
        Me.ToolTip.StripAmpersands = True
        '
        'frmSccEditTramiteLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 362)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbxDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditTramiteLegal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Trámite"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.cmbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaPedido As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroEntrega As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents cmbClientes As C1.Win.C1List.C1Combo
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblEntregadoa As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleados As C1.Win.C1List.C1Combo
    Friend WithEvents cmbExpedientes As C1.Win.C1List.C1Combo
    Friend WithEvents lblExpediente As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblSaldoFecha As System.Windows.Forms.Label
End Class
