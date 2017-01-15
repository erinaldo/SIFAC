<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePivotCuotasVencidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportePivotCuotasVencidas))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.PivotConsolidado = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SIFACPIVOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIFACPIVOT = New SIFAC.SIFACPIVOT()
        Me.coCuotasVencidas = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNumeroCuenta = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colSaldo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colRuta = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCobrador = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNombreCliente = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCiudad = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colSupervisor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPIVOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPIVOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbProductos.SuspendLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Contenedor)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 39)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1010, 641)
        Me.PanelControl1.TabIndex = 3
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.PivotConsolidado)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "98.6991869918699:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.2047713717694:False:False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(2, 2)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1006, 615)
        Me.Contenedor.TabIndex = 132
        Me.Contenedor.TabStop = False
        '
        'PivotConsolidado
        '
        Me.PivotConsolidado.DataSource = Me.SIFACPIVOTBindingSource
        Me.PivotConsolidado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotConsolidado.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.coCuotasVencidas, Me.colNumeroCuenta, Me.colSaldo, Me.colRuta, Me.colCobrador, Me.colNombreCliente, Me.colCiudad, Me.colSupervisor})
        Me.PivotConsolidado.Location = New System.Drawing.Point(0, 0)
        Me.PivotConsolidado.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PivotConsolidado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotConsolidado.Name = "PivotConsolidado"
        Me.PivotConsolidado.Size = New System.Drawing.Size(1006, 615)
        Me.PivotConsolidado.TabIndex = 0
        '
        'SIFACPIVOTBindingSource
        '
        Me.SIFACPIVOTBindingSource.DataSource = Me.SIFACPIVOT
        Me.SIFACPIVOTBindingSource.Position = 0
        '
        'SIFACPIVOT
        '
        Me.SIFACPIVOT.DataSetName = "SIFACPIVOT"
        Me.SIFACPIVOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'coCuotasVencidas
        '
        Me.coCuotasVencidas.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.coCuotasVencidas.AreaIndex = 0
        Me.coCuotasVencidas.Caption = "Cuotas Vencidas"
        Me.coCuotasVencidas.FieldName = "CuotasVencidas"
        Me.coCuotasVencidas.Name = "coCuotasVencidas"
        '
        'colNumeroCuenta
        '
        Me.colNumeroCuenta.AreaIndex = 2
        Me.colNumeroCuenta.Caption = "Numero de Cuenta"
        Me.colNumeroCuenta.FieldName = "NumeroCuenta"
        Me.colNumeroCuenta.Name = "colNumeroCuenta"
        Me.colNumeroCuenta.Width = 133
        '
        'colSaldo
        '
        Me.colSaldo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colSaldo.AreaIndex = 1
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        '
        'colRuta
        '
        Me.colRuta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRuta.AreaIndex = 1
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        '
        'colCobrador
        '
        Me.colCobrador.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCobrador.AreaIndex = 2
        Me.colCobrador.Caption = "Cobrador"
        Me.colCobrador.FieldName = "Cobrador"
        Me.colCobrador.Name = "colCobrador"
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AreaIndex = 0
        Me.colNombreCliente.Caption = "Cliente"
        Me.colNombreCliente.FieldName = "Cliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        '
        'colCiudad
        '
        Me.colCiudad.AreaIndex = 1
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        '
        'colSupervisor
        '
        Me.colSupervisor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colSupervisor.AreaIndex = 0
        Me.colSupervisor.Caption = "Supervisor"
        Me.colSupervisor.FieldName = "Supervisor"
        Me.colSupervisor.Name = "colSupervisor"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 617)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 22)
        Me.Panel1.TabIndex = 131
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRefrescar, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(1010, 39)
        Me.tbProductos.TabIndex = 10
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "ToolStripButton1"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCerrar.ToolTipText = "Salir de Catálogo de Productos"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaDesde.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.ClearText = "&Clear"
        Me.dtpFechaDesde.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.SelectedDate = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.dtpFechaDesde.Calendar.TodayText = "&Today"
        Me.dtpFechaDesde.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(53, 31)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaDesde.TabIndex = 0
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaHasta.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.ClearText = "&Clear"
        Me.dtpFechaHasta.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.SelectedDate = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.dtpFechaHasta.Calendar.TodayText = "&Today"
        Me.dtpFechaHasta.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(260, 31)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaHasta.TabIndex = 1
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'frmReportePivotCuotasVencidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 680)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportePivotCuotasVencidas"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPIVOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPIVOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents PivotConsolidado As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents SIFACPIVOTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIFACPIVOT As SIFAC.SIFACPIVOT
    Friend WithEvents coCuotasVencidas As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNumeroCuenta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSaldo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRuta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCobrador As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNombreCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCiudad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSupervisor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
End Class
