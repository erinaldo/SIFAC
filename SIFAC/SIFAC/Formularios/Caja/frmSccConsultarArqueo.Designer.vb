<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccConsultarArqueo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccConsultarArqueo))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAprobar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.spnDisponible = New DevExpress.XtraEditors.SpinEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spnFaltante = New DevExpress.XtraEditors.SpinEdit()
        Me.spnEgreso = New DevExpress.XtraEditors.SpinEdit()
        Me.spnIngreso = New DevExpress.XtraEditors.SpinEdit()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCajero = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAprobadoPor = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.spnDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnEgreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAprobar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(629, 423)
        Me.PanelControl1.TabIndex = 99
        '
        'cmdAprobar
        '
        Me.cmdAprobar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAprobar.Appearance.Options.UseFont = True
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAprobar.Location = New System.Drawing.Point(453, 354)
        Me.cmdAprobar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAprobar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAprobar.TabIndex = 98
        Me.cmdAprobar.Tag = "APROBAR"
        Me.cmdAprobar.Text = "&Aprobar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 152)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'grdDetalle
        '
        Me.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalle.Location = New System.Drawing.Point(3, 16)
        Me.grdDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDetalle.MainView = Me.grdDetalleTabla
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdDetalle.Size = New System.Drawing.Size(596, 133)
        Me.grdDetalle.TabIndex = 10
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleTabla})
        '
        'grdDetalleTabla
        '
        Me.grdDetalleTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConcepto, Me.colEntrada, Me.colSalida})
        Me.grdDetalleTabla.GridControl = Me.grdDetalle
        Me.grdDetalleTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdDetalleTabla.Name = "grdDetalleTabla"
        Me.grdDetalleTabla.OptionsView.ShowGroupPanel = False
        Me.grdDetalleTabla.Tag = ""
        '
        'colConcepto
        '
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.OptionsColumn.ReadOnly = True
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 0
        Me.colConcepto.Width = 268
        '
        'colEntrada
        '
        Me.colEntrada.Caption = "Entrada"
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.OptionsColumn.AllowEdit = False
        Me.colEntrada.Visible = True
        Me.colEntrada.VisibleIndex = 1
        Me.colEntrada.Width = 91
        '
        'colSalida
        '
        Me.colSalida.Caption = "Salida"
        Me.colSalida.FieldName = "Salida"
        Me.colSalida.Name = "colSalida"
        Me.colSalida.OptionsColumn.AllowEdit = False
        Me.colSalida.OptionsColumn.ReadOnly = True
        Me.colSalida.Visible = True
        Me.colSalida.VisibleIndex = 2
        Me.colSalida.Width = 103
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 21)
        Me.Panel1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(539, 354)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.lblCaja)
        Me.gbxDatosGenerales.Controls.Add(Me.spnDisponible)
        Me.gbxDatosGenerales.Controls.Add(Me.Label5)
        Me.gbxDatosGenerales.Controls.Add(Me.Label4)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.spnFaltante)
        Me.gbxDatosGenerales.Controls.Add(Me.spnEgreso)
        Me.gbxDatosGenerales.Controls.Add(Me.spnIngreso)
        Me.gbxDatosGenerales.Controls.Add(Me.dtFecha)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCajero)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.txtAprobadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(12, 11)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(602, 175)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Informacion General"
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(462, 18)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(40, 13)
        Me.lblCaja.TabIndex = 145
        Me.lblCaja.Tag = ""
        Me.lblCaja.Text = "Caja: "
        '
        'spnDisponible
        '
        Me.spnDisponible.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnDisponible.Enabled = False
        Me.spnDisponible.Location = New System.Drawing.Point(429, 117)
        Me.spnDisponible.Name = "spnDisponible"
        Me.spnDisponible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnDisponible.Properties.Mask.EditMask = "n"
        Me.spnDisponible.Size = New System.Drawing.Size(141, 20)
        Me.spnDisponible.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 143
        Me.Label5.Tag = ""
        Me.Label5.Text = "Disponible en efectivo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Tag = ""
        Me.Label4.Text = "Faltante/Excedente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Tag = ""
        Me.Label3.Text = "Egreso:"
        '
        'spnFaltante
        '
        Me.spnFaltante.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnFaltante.Location = New System.Drawing.Point(138, 148)
        Me.spnFaltante.Name = "spnFaltante"
        Me.spnFaltante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnFaltante.Properties.Mask.EditMask = "n"
        Me.spnFaltante.Size = New System.Drawing.Size(100, 20)
        Me.spnFaltante.TabIndex = 140
        '
        'spnEgreso
        '
        Me.spnEgreso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnEgreso.Enabled = False
        Me.spnEgreso.Location = New System.Drawing.Point(138, 122)
        Me.spnEgreso.Name = "spnEgreso"
        Me.spnEgreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnEgreso.Properties.Mask.EditMask = "n"
        Me.spnEgreso.Size = New System.Drawing.Size(100, 20)
        Me.spnEgreso.TabIndex = 139
        '
        'spnIngreso
        '
        Me.spnIngreso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnIngreso.Enabled = False
        Me.spnIngreso.Location = New System.Drawing.Point(138, 96)
        Me.spnIngreso.Name = "spnIngreso"
        Me.spnIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnIngreso.Properties.Mask.EditMask = "c"
        Me.spnIngreso.Size = New System.Drawing.Size(100, 20)
        Me.spnIngreso.TabIndex = 138
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(138, 17)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(177, 20)
        Me.dtFecha.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Fecha:"
        '
        'cmbCajero
        '
        Me.cmbCajero.Enabled = False
        Me.cmbCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.FormattingEnabled = True
        Me.cmbCajero.Location = New System.Drawing.Point(138, 43)
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.Size = New System.Drawing.Size(279, 21)
        Me.cmbCajero.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Cajero(a):"
        '
        'txtAprobadoPor
        '
        Me.txtAprobadoPor.Location = New System.Drawing.Point(138, 70)
        Me.txtAprobadoPor.Name = "txtAprobadoPor"
        Me.txtAprobadoPor.Size = New System.Drawing.Size(279, 20)
        Me.txtAprobadoPor.TabIndex = 0
        Me.txtAprobadoPor.TabStop = False
        Me.txtAprobadoPor.Tag = "BLOQUEADO"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(11, 100)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(53, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = ""
        Me.lblDescripcion.Text = "Ingreso:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(11, 73)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(87, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Aprobado por:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccConsultarArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 423)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccConsultarArqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar arqueo de Caja"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.spnDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnEgreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAprobadoPor As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents spnFaltante As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnEgreso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnIngreso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents spnDisponible As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmdAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
End Class
