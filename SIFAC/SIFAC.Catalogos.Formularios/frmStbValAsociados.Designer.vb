<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbValAsociados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbValAsociados))
        Me.grdDatosvalores = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDatosvalores
        '
        Me.grdDatosvalores.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDatosvalores.ExtendRightColumn = True
        Me.grdDatosvalores.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDatosvalores.Images.Add(CType(resources.GetObject("grdDatosvalores.Images"), System.Drawing.Image))
        Me.grdDatosvalores.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosvalores.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdDatosvalores.Name = "grdDatosvalores"
        Me.grdDatosvalores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosvalores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosvalores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDatosvalores.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosvalores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosvalores.Size = New System.Drawing.Size(369, 203)
        Me.grdDatosvalores.TabIndex = 1
        Me.grdDatosvalores.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdDatosvalores.PropBag = resources.GetString("grdDatosvalores.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(201, 208)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 34)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(282, 208)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'frmStbValAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 247)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grdDatosvalores)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbValAsociados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Valores Asociados al Cat�logo"
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDatosvalores As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
End Class
