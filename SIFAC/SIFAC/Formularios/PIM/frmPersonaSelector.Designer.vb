<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonaSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonaSelector))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevaPersona = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdPersonas = New DevExpress.XtraGrid.GridControl()
        Me.grdvwPersonas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCedula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCompleto = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.SimpleButton1)
        Me.pnlBotones.Controls.Add(Me.cmdGuardar)
        Me.pnlBotones.Controls.Add(Me.cmdNuevaPersona)
        Me.pnlBotones.Location = New System.Drawing.Point(0, 289)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(502, 49)
        Me.pnlBotones.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(418, 13)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(332, 13)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 6
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'cmdNuevaPersona
        '
        Me.cmdNuevaPersona.Image = CType(resources.GetObject("cmdNuevaPersona.Image"), System.Drawing.Image)
        Me.cmdNuevaPersona.Location = New System.Drawing.Point(286, 9)
        Me.cmdNuevaPersona.Name = "cmdNuevaPersona"
        Me.cmdNuevaPersona.Size = New System.Drawing.Size(40, 35)
        Me.cmdNuevaPersona.TabIndex = 0
        Me.cmdNuevaPersona.UseVisualStyleBackColor = True
        Me.cmdNuevaPersona.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 16)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdPersonas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(502, 363)
        Me.PanelControl1.TabIndex = 8
        '
        'grdPersonas
        '
        Me.grdPersonas.Location = New System.Drawing.Point(0, 0)
        Me.grdPersonas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdPersonas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdPersonas.MainView = Me.grdvwPersonas
        Me.grdPersonas.Name = "grdPersonas"
        Me.grdPersonas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado})
        Me.grdPersonas.Size = New System.Drawing.Size(502, 292)
        Me.grdPersonas.TabIndex = 0
        Me.grdPersonas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwPersonas})
        '
        'grdvwPersonas
        '
        Me.grdvwPersonas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSeleccionar, Me.colCedula, Me.colNombreCompleto})
        Me.grdvwPersonas.GridControl = Me.grdPersonas
        Me.grdvwPersonas.Name = "grdvwPersonas"
        Me.grdvwPersonas.OptionsView.ColumnAutoWidth = False
        Me.grdvwPersonas.OptionsView.ShowAutoFilterRow = True
        Me.grdvwPersonas.OptionsView.ShowDetailButtons = False
        Me.grdvwPersonas.OptionsView.ShowGroupPanel = False
        '
        'ColSeleccionar
        '
        Me.ColSeleccionar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSeleccionar.AppearanceHeader.Options.UseFont = True
        Me.ColSeleccionar.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSeleccionar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSeleccionar.Caption = "Seleccionar"
        Me.ColSeleccionar.ColumnEdit = Me.chkSeleccionado
        Me.ColSeleccionar.FieldName = "Seleccionar"
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.OptionsColumn.AllowMove = False
        Me.ColSeleccionar.OptionsFilter.AllowAutoFilter = False
        Me.ColSeleccionar.OptionsFilter.AllowFilter = False
        Me.ColSeleccionar.Visible = True
        Me.ColSeleccionar.VisibleIndex = 0
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'colCedula
        '
        Me.colCedula.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCedula.AppearanceHeader.Options.UseFont = True
        Me.colCedula.AppearanceHeader.Options.UseTextOptions = True
        Me.colCedula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCedula.Caption = "Identificacion"
        Me.colCedula.FieldName = "Cedula"
        Me.colCedula.Name = "colCedula"
        Me.colCedula.OptionsColumn.AllowEdit = False
        Me.colCedula.OptionsColumn.AllowMove = False
        Me.colCedula.OptionsFilter.AllowAutoFilter = False
        Me.colCedula.OptionsFilter.AllowFilter = False
        Me.colCedula.Visible = True
        Me.colCedula.VisibleIndex = 1
        Me.colCedula.Width = 108
        '
        'colNombreCompleto
        '
        Me.colNombreCompleto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCompleto.AppearanceHeader.Options.UseFont = True
        Me.colNombreCompleto.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCompleto.Caption = "Nombre Completo"
        Me.colNombreCompleto.FieldName = "NombreCompleto"
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.OptionsColumn.AllowEdit = False
        Me.colNombreCompleto.OptionsColumn.AllowMove = False
        Me.colNombreCompleto.OptionsFilter.AllowAutoFilter = False
        Me.colNombreCompleto.OptionsFilter.AllowFilter = False
        Me.colNombreCompleto.Visible = True
        Me.colNombreCompleto.VisibleIndex = 2
        Me.colNombreCompleto.Width = 300
        '
        'frmPersonaSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 363)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonaSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Personas"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents cmdNuevaPersona As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdPersonas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwPersonas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCedula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCompleto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
