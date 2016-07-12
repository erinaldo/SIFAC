<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorRS
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
        Me.VisorReportes = New Microsoft.Reporting.WinForms.ReportViewer
        Me.SuspendLayout()
        '
        'VisorReportes
        '
        Me.VisorReportes.AllowDrop = True
        Me.VisorReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReportes.Location = New System.Drawing.Point(0, 0)
        Me.VisorReportes.Name = "VisorReportes"
        Me.VisorReportes.Size = New System.Drawing.Size(657, 427)
        Me.VisorReportes.TabIndex = 0
        '
        'frmVisorRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 427)
        Me.Controls.Add(Me.VisorReportes)
        Me.Name = "frmVisorRS"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisorReportes As Microsoft.Reporting.WinForms.ReportViewer
End Class
