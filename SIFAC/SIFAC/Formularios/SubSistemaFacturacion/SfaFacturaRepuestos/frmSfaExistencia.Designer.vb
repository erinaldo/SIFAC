<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaExistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaExistencia))
        Me.PanelExistencia = New System.Windows.Forms.Panel()
        Me.grdExistencia = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelExistencia.SuspendLayout()
        CType(Me.grdExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelExistencia
        '
        Me.PanelExistencia.Controls.Add(Me.grdExistencia)
        Me.PanelExistencia.Location = New System.Drawing.Point(12, 15)
        Me.PanelExistencia.Name = "PanelExistencia"
        Me.PanelExistencia.Size = New System.Drawing.Size(332, 161)
        Me.PanelExistencia.TabIndex = 0
        '
        'grdExistencia
        '
        Me.grdExistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExistencia.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdExistencia.Images.Add(CType(resources.GetObject("grdExistencia.Images"), System.Drawing.Image))
        Me.grdExistencia.Location = New System.Drawing.Point(0, 0)
        Me.grdExistencia.Name = "grdExistencia"
        Me.grdExistencia.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdExistencia.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdExistencia.PreviewInfo.ZoomFactor = 75.0R
        Me.grdExistencia.PrintInfo.PageSettings = CType(resources.GetObject("grdExistencia.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdExistencia.Size = New System.Drawing.Size(332, 161)
        Me.grdExistencia.TabIndex = 0
        Me.grdExistencia.PropBag = resources.GetString("grdExistencia.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 22)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ESC = Salir"
        '
        'frmSfaExistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 226)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelExistencia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaExistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de existencia"
        Me.PanelExistencia.ResumeLayout(False)
        CType(Me.grdExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelExistencia As System.Windows.Forms.Panel
    Friend WithEvents grdExistencia As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
