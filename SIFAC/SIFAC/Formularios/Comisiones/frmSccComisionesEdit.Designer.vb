<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccComisionesEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccComisionesEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbCajero = New C1.Win.C1List.C1Combo()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEmpleado = New C1.Win.C1List.C1Combo()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.dtHasta = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.cmdJefe = New System.Windows.Forms.Button()
        Me.dtDesde = New DevExpress.XtraEditors.DateEdit()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.dtFechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdVerDetalle = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SpnTotalRecuperado = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SpnPorcentaje = New DevExpress.XtraEditors.SpinEdit()
        Me.SpnTotal = New DevExpress.XtraEditors.SpinEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.dtFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpnTotalRecuperado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpnPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpnTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbCajero)
        Me.PanelControl1.Controls.Add(Me.lblCaja)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.lblCajero)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(510, 393)
        Me.PanelControl1.TabIndex = 99
        '
        'cmbCajero
        '
        Me.cmbCajero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCajero.AutoCompletion = True
        Me.cmbCajero.AutoDropDown = True
        Me.cmbCajero.Caption = ""
        Me.cmbCajero.CaptionHeight = 17
        Me.cmbCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCajero.ColumnCaptionHeight = 17
        Me.cmbCajero.ColumnFooterHeight = 17
        Me.cmbCajero.ContentHeight = 15
        Me.cmbCajero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCajero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCajero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCajero.EditorHeight = 15
        Me.cmbCajero.Images.Add(CType(resources.GetObject("cmbCajero.Images"), System.Drawing.Image))
        Me.cmbCajero.ItemHeight = 15
        Me.cmbCajero.Location = New System.Drawing.Point(153, 296)
        Me.cmbCajero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCajero.MaxDropDownItems = CType(5, Short)
        Me.cmbCajero.MaxLength = 32767
        Me.cmbCajero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCajero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCajero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCajero.Size = New System.Drawing.Size(279, 21)
        Me.cmbCajero.TabIndex = 0
        Me.cmbCajero.Tag = "OBLIGATORIO"
        Me.cmbCajero.PropBag = resources.GetString("cmbCajero.PropBag")
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(27, 333)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(40, 13)
        Me.lblCaja.TabIndex = 146
        Me.lblCaja.Tag = ""
        Me.lblCaja.Text = "Caja: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEmpleado)
        Me.GroupBox1.Controls.Add(Me.cmdCargar)
        Me.GroupBox1.Controls.Add(Me.dtHasta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblSfaPromocionID)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.cmdJefe)
        Me.GroupBox1.Controls.Add(Me.dtDesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 113)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios de busqueda"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEmpleado.AutoCompletion = True
        Me.cmbEmpleado.AutoDropDown = True
        Me.cmbEmpleado.Caption = ""
        Me.cmbEmpleado.CaptionHeight = 17
        Me.cmbEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEmpleado.ColumnCaptionHeight = 17
        Me.cmbEmpleado.ColumnFooterHeight = 17
        Me.cmbEmpleado.ContentHeight = 15
        Me.cmbEmpleado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEmpleado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEmpleado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEmpleado.EditorHeight = 15
        Me.cmbEmpleado.Images.Add(CType(resources.GetObject("cmbEmpleado.Images"), System.Drawing.Image))
        Me.cmbEmpleado.ItemHeight = 15
        Me.cmbEmpleado.Location = New System.Drawing.Point(139, 25)
        Me.cmbEmpleado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEmpleado.MaxDropDownItems = CType(5, Short)
        Me.cmbEmpleado.MaxLength = 32767
        Me.cmbEmpleado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEmpleado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEmpleado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEmpleado.Size = New System.Drawing.Size(279, 21)
        Me.cmbEmpleado.TabIndex = 0
        Me.cmbEmpleado.Tag = "OBLIGATORIO"
        Me.cmbEmpleado.PropBag = resources.GetString("cmbEmpleado.PropBag")
        '
        'cmdCargar
        '
        Me.cmdCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCargar.Image = CType(resources.GetObject("cmdCargar.Image"), System.Drawing.Image)
        Me.cmdCargar.Location = New System.Drawing.Point(293, 74)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(36, 27)
        Me.cmdCargar.TabIndex = 4
        Me.cmdCargar.Tag = "Ver Detalle"
        Me.cmdCargar.UseVisualStyleBackColor = True
        '
        'dtHasta
        '
        Me.dtHasta.EditValue = Nothing
        Me.dtHasta.Location = New System.Drawing.Point(139, 78)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHasta.Size = New System.Drawing.Size(148, 20)
        Me.dtHasta.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Hasta:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(16, 55)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(47, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Desde:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = "OBLIGATORIO"
        Me.lblDescripcion.Text = "Empleado:"
        '
        'cmdJefe
        '
        Me.cmdJefe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJefe.Location = New System.Drawing.Point(424, 24)
        Me.cmdJefe.Name = "cmdJefe"
        Me.cmdJefe.Size = New System.Drawing.Size(33, 21)
        Me.cmdJefe.TabIndex = 1
        Me.cmdJefe.Text = "···"
        Me.cmdJefe.UseVisualStyleBackColor = True
        '
        'dtDesde
        '
        Me.dtDesde.EditValue = Nothing
        Me.dtDesde.Location = New System.Drawing.Point(139, 52)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDesde.Size = New System.Drawing.Size(148, 20)
        Me.dtDesde.TabIndex = 2
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(26, 305)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(62, 13)
        Me.lblCajero.TabIndex = 147
        Me.lblCajero.Tag = "OBLIGATORIO"
        Me.lblCajero.Text = "Cajero(a):"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(423, 334)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(337, 334)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 1
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.dtFechaPago)
        Me.gbxDatosGenerales.Controls.Add(Me.Label7)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdVerDetalle)
        Me.gbxDatosGenerales.Controls.Add(Me.txtEstado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label4)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.SpnTotalRecuperado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.SpnPorcentaje)
        Me.gbxDatosGenerales.Controls.Add(Me.SpnTotal)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(12, 129)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(483, 161)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'dtFechaPago
        '
        Me.dtFechaPago.EditValue = Nothing
        Me.dtFechaPago.Location = New System.Drawing.Point(141, 126)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaPago.Size = New System.Drawing.Size(148, 20)
        Me.dtFechaPago.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Fecha de pago:"
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerDetalle.Image = CType(resources.GetObject("cmdVerDetalle.Image"), System.Drawing.Image)
        Me.cmdVerDetalle.Location = New System.Drawing.Point(279, 45)
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(33, 21)
        Me.cmdVerDetalle.TabIndex = 2
        Me.cmdVerDetalle.Tag = "Ver Detalle"
        Me.cmdVerDetalle.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(141, 19)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(279, 20)
        Me.txtEstado.TabIndex = 0
        Me.txtEstado.TabStop = False
        Me.txtEstado.Tag = "BLOQUEADO"
        Me.txtEstado.Text = "REGISTRADA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Total recuperado:"
        '
        'SpnTotalRecuperado
        '
        Me.SpnTotalRecuperado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnTotalRecuperado.Enabled = False
        Me.SpnTotalRecuperado.Location = New System.Drawing.Point(141, 45)
        Me.SpnTotalRecuperado.Name = "SpnTotalRecuperado"
        Me.SpnTotalRecuperado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpnTotalRecuperado.Size = New System.Drawing.Size(134, 20)
        Me.SpnTotalRecuperado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Total:"
        '
        'SpnPorcentaje
        '
        Me.SpnPorcentaje.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnPorcentaje.Location = New System.Drawing.Point(141, 71)
        Me.SpnPorcentaje.Name = "SpnPorcentaje"
        Me.SpnPorcentaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpnPorcentaje.Size = New System.Drawing.Size(134, 20)
        Me.SpnPorcentaje.TabIndex = 3
        '
        'SpnTotal
        '
        Me.SpnTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnTotal.Enabled = False
        Me.SpnTotal.Location = New System.Drawing.Point(141, 97)
        Me.SpnTotal.Name = "SpnTotal"
        Me.SpnTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpnTotal.Size = New System.Drawing.Size(134, 20)
        Me.SpnTotal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Porcentaje:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 21)
        Me.Panel1.TabIndex = 100
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccComisionesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccComisionesEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registar Comisiones"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.dtFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpnTotalRecuperado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpnPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpnTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdJefe As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents dtDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SpnTotalRecuperado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpnPorcentaje As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpnTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdVerDetalle As System.Windows.Forms.Button
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdCargar As System.Windows.Forms.Button
    Friend WithEvents dtFechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCajero As C1.Win.C1List.C1Combo
End Class
