<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleComision))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSccReciboCajaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalRecaudado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblEmpleado)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(613, 246)
        Me.PanelControl1.TabIndex = 100
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.Location = New System.Drawing.Point(23, 9)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(0, 16)
        Me.lblEmpleado.TabIndex = 4
        Me.lblEmpleado.Tag = ""
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(528, 213)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.grdDetalle)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(13, 16)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(590, 191)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
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
        Me.grdDetalle.Size = New System.Drawing.Size(584, 172)
        Me.grdDetalle.TabIndex = 11
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleTabla})
        '
        'grdDetalleTabla
        '
        Me.grdDetalleTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colNumCuenta, Me.colRuta, Me.colCliente, Me.colSccReciboCajaID, Me.colTotalRecaudado})
        Me.grdDetalleTabla.GridControl = Me.grdDetalle
        Me.grdDetalleTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdDetalleTabla.Name = "grdDetalleTabla"
        Me.grdDetalleTabla.OptionsView.ShowGroupPanel = False
        Me.grdDetalleTabla.Tag = ""
        '
        'colNumCuenta
        '
        Me.colNumCuenta.Caption = "Cuenta"
        Me.colNumCuenta.FieldName = "NumCuenta"
        Me.colNumCuenta.Name = "colNumCuenta"
        Me.colNumCuenta.OptionsColumn.AllowEdit = False
        Me.colNumCuenta.OptionsColumn.ReadOnly = True
        Me.colNumCuenta.Visible = True
        Me.colNumCuenta.VisibleIndex = 2
        Me.colNumCuenta.Width = 77
        '
        'colRuta
        '
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.OptionsColumn.AllowEdit = False
        Me.colRuta.Visible = True
        Me.colRuta.VisibleIndex = 1
        Me.colRuta.Width = 74
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 208
        '
        'colSccReciboCajaID
        '
        Me.colSccReciboCajaID.Caption = "SccReciboCajaID"
        Me.colSccReciboCajaID.FieldName = "SccReciboCajaID"
        Me.colSccReciboCajaID.Name = "colSccReciboCajaID"
        Me.colSccReciboCajaID.OptionsColumn.AllowEdit = False
        '
        'colTotalRecaudado
        '
        Me.colTotalRecaudado.Caption = "Abono"
        Me.colTotalRecaudado.FieldName = "TotalRecaudado"
        Me.colTotalRecaudado.Name = "colTotalRecaudado"
        Me.colTotalRecaudado.OptionsColumn.AllowEdit = False
        Me.colTotalRecaudado.Visible = True
        Me.colTotalRecaudado.VisibleIndex = 4
        Me.colTotalRecaudado.Width = 107
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 100
        '
        'frmDetalleComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 246)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalleComision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Comision"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.gbxDatosGenerales.ResumeLayout(False)
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents colSccReciboCajaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalRecaudado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
End Class
