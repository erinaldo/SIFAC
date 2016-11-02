<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePivot
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
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportePivot))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.PivotConsolidado = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SIFACPIVOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIFACPIVOT = New SIFAC.SIFACPIVOT()
        Me.colSaldoInicial = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colMontoPagado = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colSaldo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colFechaPago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colRuta = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCodigoRuta = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCobrador = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNombreCliente = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCiudad = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colSupervisor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colAnio = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ColMes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ColDia = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPIVOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPIVOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbProductos.SuspendLayout()
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
        Me.Contenedor.Controls.Add(Me.ChartControl1)
        Me.Contenedor.Controls.Add(Me.gbxPeriodo)
        Me.Contenedor.Controls.Add(Me.PivotConsolidado)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "11.0569105691057:False:False;45.6910569105691:False:False;40.650406504065:False:F" & _
    "alse;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.2047713717694:False:False;"
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
        Me.PivotConsolidado.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colSaldoInicial, Me.colMontoPagado, Me.colSaldo, Me.colFechaPago, Me.colRuta, Me.colCodigoRuta, Me.colCobrador, Me.colNombreCliente, Me.colCiudad, Me.colSupervisor, Me.colAnio, Me.ColMes, Me.ColDia})
        Me.PivotConsolidado.Location = New System.Drawing.Point(4, 76)
        Me.PivotConsolidado.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PivotConsolidado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotConsolidado.Name = "PivotConsolidado"
        Me.PivotConsolidado.Size = New System.Drawing.Size(998, 281)
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
        'colSaldoInicial
        '
        Me.colSaldoInicial.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colSaldoInicial.AreaIndex = 0
        Me.colSaldoInicial.Caption = "Saldo Inicial"
        Me.colSaldoInicial.FieldName = "SaldoInicial"
        Me.colSaldoInicial.Name = "colSaldoInicial"
        '
        'colMontoPagado
        '
        Me.colMontoPagado.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMontoPagado.AreaIndex = 1
        Me.colMontoPagado.Caption = "Monto Pagado"
        Me.colMontoPagado.FieldName = "MontoPagado"
        Me.colMontoPagado.Name = "colMontoPagado"
        '
        'colSaldo
        '
        Me.colSaldo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colSaldo.AreaIndex = 2
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        '
        'colFechaPago
        '
        Me.colFechaPago.AreaIndex = 0
        Me.colFechaPago.Caption = "Fecha de Pago"
        Me.colFechaPago.FieldName = "FechaPago"
        Me.colFechaPago.Name = "colFechaPago"
        '
        'colRuta
        '
        Me.colRuta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRuta.AreaIndex = 1
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        '
        'colCodigoRuta
        '
        Me.colCodigoRuta.AreaIndex = 2
        Me.colCodigoRuta.Caption = "CodigoRuta"
        Me.colCodigoRuta.FieldName = "CodigoRuta"
        Me.colCodigoRuta.Name = "colCodigoRuta"
        '
        'colCobrador
        '
        Me.colCobrador.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCobrador.AreaIndex = 3
        Me.colCobrador.Caption = "Cobrador"
        Me.colCobrador.FieldName = "Cobrador"
        Me.colCobrador.Name = "colCobrador"
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AreaIndex = 1
        Me.colNombreCliente.Caption = "Cliente"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        '
        'colCiudad
        '
        Me.colCiudad.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCiudad.AreaIndex = 0
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        '
        'colSupervisor
        '
        Me.colSupervisor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colSupervisor.AreaIndex = 2
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
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label2)
        Me.gbxPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPeriodo.Location = New System.Drawing.Point(4, 4)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(998, 68)
        Me.gbxPeriodo.TabIndex = 104
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Período"
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
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.ForeColor = System.Drawing.Color.Black
        Me.lblHasta.Location = New System.Drawing.Point(213, 32)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(44, 13)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'colAnio
        '
        Me.colAnio.AreaIndex = 3
        Me.colAnio.Caption = "Año"
        Me.colAnio.FieldName = "Anio"
        Me.colAnio.Name = "colAnio"
        '
        'ColMes
        '
        Me.ColMes.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.ColMes.AreaIndex = 0
        Me.ColMes.Caption = "Mes"
        Me.ColMes.FieldName = "Mes"
        Me.ColMes.Name = "ColMes"
        '
        'ColDia
        '
        Me.ColDia.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.ColDia.AreaIndex = 1
        Me.ColDia.Caption = "Dia"
        Me.ColDia.FieldName = "Dia"
        Me.ColDia.Name = "ColDia"
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.PivotConsolidado
        XyDiagram3.AxisX.Title.Text = "Ciudad Ruta Supervisor Cobrador"
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.Title.Text = "Saldo Inicial Monto Pagado Saldo"
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram3
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Location = New System.Drawing.Point(4, 361)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.ChartControl1.SeriesTemplate.SynchronizePointOptions = False
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.Size = New System.Drawing.Size(998, 250)
        Me.ChartControl1.TabIndex = 105
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
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'frmReportePivot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 680)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportePivot"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPIVOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPIVOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents PivotConsolidado As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents SIFACPIVOTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIFACPIVOT As SIFAC.SIFACPIVOT
    Friend WithEvents colSaldoInicial As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMontoPagado As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSaldo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFechaPago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRuta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCodigoRuta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCobrador As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNombreCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCiudad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSupervisor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAnio As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColMes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColDia As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
End Class
