<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prueba
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VwSivPedidosMasterBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIFACPedidosMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIFACPedidosMaster = New SIFAC.SIFACPedidosMaster()
        Me.OfficeNavigationBar1 = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.VwSivPedidosMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSivPedidosMasterTableAdapter = New SIFAC.SIFACPedidosMasterTableAdapters.vwSivPedidosMasterTableAdapter()
        Me.VwSivPedidosMasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAbono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoAbonado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeloMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSivPedidosMasterBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPedidosMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIFACPedidosMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSivPedidosMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSivPedidosMasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSccCuentaID, Me.colModeloMarca, Me.colProducto, Me.colSaldo})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(834, 395)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRuta, Me.colCliente, Me.colMontoAbonado, Me.colFechaAbono, Me.colEmpleado, Me.colobjSccCuentaID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'VwSivPedidosMasterBindingSource2
        '
        Me.VwSivPedidosMasterBindingSource2.DataMember = "vwSivPedidosMaster"
        Me.VwSivPedidosMasterBindingSource2.DataSource = Me.SIFACPedidosMasterBindingSource
        '
        'SIFACPedidosMasterBindingSource
        '
        Me.SIFACPedidosMasterBindingSource.DataSource = Me.SIFACPedidosMaster
        Me.SIFACPedidosMasterBindingSource.Position = 0
        '
        'SIFACPedidosMaster
        '
        Me.SIFACPedidosMaster.DataSetName = "SIFACPedidosMaster"
        Me.SIFACPedidosMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfficeNavigationBar1
        '
        Me.OfficeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OfficeNavigationBar1.Location = New System.Drawing.Point(0, 395)
        Me.OfficeNavigationBar1.Name = "OfficeNavigationBar1"
        Me.OfficeNavigationBar1.Size = New System.Drawing.Size(834, 0)
        Me.OfficeNavigationBar1.TabIndex = 5
        Me.OfficeNavigationBar1.Text = "OfficeNavigationBar1"
        '
        'VwSivPedidosMasterBindingSource
        '
        Me.VwSivPedidosMasterBindingSource.DataMember = "vwSivPedidosMaster"
        Me.VwSivPedidosMasterBindingSource.DataSource = Me.SIFACPedidosMaster
        '
        'VwSivPedidosMasterTableAdapter
        '
        Me.VwSivPedidosMasterTableAdapter.ClearBeforeFill = True
        '
        'VwSivPedidosMasterBindingSource1
        '
        Me.VwSivPedidosMasterBindingSource1.DataMember = "vwSivPedidosMaster"
        Me.VwSivPedidosMasterBindingSource1.DataSource = Me.SIFACPedidosMasterBindingSource
        '
        'colRuta
        '
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.Visible = True
        Me.colRuta.VisibleIndex = 1
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        '
        'colFechaAbono
        '
        Me.colFechaAbono.Caption = "FechaAbono"
        Me.colFechaAbono.FieldName = "FechaAbono"
        Me.colFechaAbono.Name = "colFechaAbono"
        Me.colFechaAbono.Visible = True
        Me.colFechaAbono.VisibleIndex = 3
        '
        'colEmpleado
        '
        Me.colEmpleado.Caption = "Empleado"
        Me.colEmpleado.FieldName = "Empleado"
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 4
        '
        'colobjSccCuentaID
        '
        Me.colobjSccCuentaID.Caption = "objSccCuentaID"
        Me.colobjSccCuentaID.FieldName = "objSccCuentaID"
        Me.colobjSccCuentaID.Name = "colobjSccCuentaID"
        Me.colobjSccCuentaID.Visible = True
        Me.colobjSccCuentaID.VisibleIndex = 0
        '
        'colMontoAbonado
        '
        Me.colMontoAbonado.Caption = "MontoAbonado"
        Me.colMontoAbonado.FieldName = "MontoAbonado"
        Me.colMontoAbonado.Name = "colMontoAbonado"
        Me.colMontoAbonado.Visible = True
        Me.colMontoAbonado.VisibleIndex = 5
        '
        'colSccCuentaID
        '
        Me.colSccCuentaID.Caption = "SccCuentaID"
        Me.colSccCuentaID.FieldName = "SccCuentaID"
        Me.colSccCuentaID.Name = "colSccCuentaID"
        Me.colSccCuentaID.Visible = True
        Me.colSccCuentaID.VisibleIndex = 0
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 2
        '
        'colModeloMarca
        '
        Me.colModeloMarca.Caption = "ModeloMarca"
        Me.colModeloMarca.FieldName = "ModeloMarca"
        Me.colModeloMarca.Name = "colModeloMarca"
        Me.colModeloMarca.Visible = True
        Me.colModeloMarca.VisibleIndex = 1
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 3
        '
        'prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 395)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.OfficeNavigationBar1)
        Me.Name = "prueba"
        Me.Text = "prueba"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSivPedidosMasterBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPedidosMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIFACPedidosMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSivPedidosMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSivPedidosMasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OfficeNavigationBar1 As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Friend WithEvents SIFACPedidosMaster As SIFAC.SIFACPedidosMaster
    Friend WithEvents VwSivPedidosMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSivPedidosMasterTableAdapter As SIFAC.SIFACPedidosMasterTableAdapters.vwSivPedidosMasterTableAdapter
    Friend WithEvents VwSivPedidosMasterBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents SIFACPedidosMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSivPedidosMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeloMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoAbonado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
End Class
