<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonasContactos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonasContactos))
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblTipoContacto = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmbTipoPersona = New C1.Win.C1List.C1Combo()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'lblTipoContacto
        '
        Me.lblTipoContacto.AutoSize = True
        Me.lblTipoContacto.Location = New System.Drawing.Point(15, 35)
        Me.lblTipoContacto.Name = "lblTipoContacto"
        Me.lblTipoContacto.Size = New System.Drawing.Size(92, 13)
        Me.lblTipoContacto.TabIndex = 0
        Me.lblTipoContacto.Text = "Tipo de Contacto:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(264, 81)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 27)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(183, 81)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 27)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoPersona.AllowColMove = False
        Me.cmbTipoPersona.AllowSort = False
        Me.cmbTipoPersona.Caption = ""
        Me.cmbTipoPersona.CaptionHeight = 17
        Me.cmbTipoPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoPersona.ColumnCaptionHeight = 17
        Me.cmbTipoPersona.ColumnFooterHeight = 17
        Me.cmbTipoPersona.ColumnHeaders = False
        Me.cmbTipoPersona.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoPersona.ContentHeight = 15
        Me.cmbTipoPersona.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoPersona.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoPersona.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoPersona.EditorHeight = 15
        Me.cmbTipoPersona.Images.Add(CType(resources.GetObject("cmbTipoPersona.Images"), System.Drawing.Image))
        Me.cmbTipoPersona.ItemHeight = 15
        Me.cmbTipoPersona.Location = New System.Drawing.Point(120, 30)
        Me.cmbTipoPersona.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPersona.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPersona.MaxLength = 32767
        Me.cmbTipoPersona.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPersona.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.Size = New System.Drawing.Size(219, 21)
        Me.cmbTipoPersona.TabIndex = 3
        Me.cmbTipoPersona.Text = "C1Combo1"
        Me.cmbTipoPersona.PropBag = resources.GetString("cmbTipoPersona.PropBag")
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(120, 55)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(219, 20)
        Me.txtValor.TabIndex = 4
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(18, 60)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 16)
        Me.Panel1.TabIndex = 26
        '
        'frmStbPersonasContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 131)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.cmbTipoPersona)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblTipoContacto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasContactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Contactos"
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblTipoContacto As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbTipoPersona As C1.Win.C1List.C1Combo
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
