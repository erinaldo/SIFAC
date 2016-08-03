<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaBusquedaCotizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaBusquedaCotizacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.grdCotizaciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.grdCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(706, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 32)
        Me.Panel2.TabIndex = 7
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 22)
        Me.Panel3.TabIndex = 8
        '
        'grdCotizaciones
        '
        Me.grdCotizaciones.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdCotizaciones.Images.Add(CType(resources.GetObject("grdCotizaciones.Images"), System.Drawing.Image))
        Me.grdCotizaciones.Location = New System.Drawing.Point(12, 67)
        Me.grdCotizaciones.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdCotizaciones.Name = "grdCotizaciones"
        Me.grdCotizaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCotizaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCotizaciones.PreviewInfo.ZoomFactor = 75
        Me.grdCotizaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdCotizaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCotizaciones.Size = New System.Drawing.Size(753, 165)
        Me.grdCotizaciones.TabIndex = 9
        Me.grdCotizaciones.Text = "C1TrueDBGrid1"
        Me.grdCotizaciones.PropBag = resources.GetString("grdCotizaciones.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Seleccione la cotización que desea facturar y de clic an Aceptar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nota: Sólo se muestran Cotizaciones vigentes"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(609, 247)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(690, 247)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSfaBusquedaCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 314)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdCotizaciones)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaBusquedaCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Cotizaciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents grdCotizaciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
