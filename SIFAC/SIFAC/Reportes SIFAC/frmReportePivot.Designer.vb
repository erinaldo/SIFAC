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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportePivot))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Contenedor)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(951, 563)
        Me.PanelControl1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 539)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 22)
        Me.Panel1.TabIndex = 131
        '
        'Contenedor
        '
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "18.6219739292365:False:False;79.1433891992551:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.155227032735:False:" & _
    "False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(2, 2)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(947, 537)
        Me.Contenedor.TabIndex = 132
        Me.Contenedor.TabStop = False
        '
        'frmReportePivot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 563)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportePivot"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
End Class
