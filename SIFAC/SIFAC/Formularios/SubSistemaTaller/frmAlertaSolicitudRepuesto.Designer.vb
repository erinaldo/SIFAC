<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertaSolicitudRepuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertaSolicitudRepuesto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grdSolicitudes = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.toolAlertas = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdAnular = New System.Windows.Forms.Button
        Me.cmdConsultar = New System.Windows.Forms.Button
        Me.cmdAutorizar = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.toolAlertas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(646, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'grdSolicitudes
        '
        Me.grdSolicitudes.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdSolicitudes.Images.Add(CType(resources.GetObject("grdSolicitudes.Images"), System.Drawing.Image))
        Me.grdSolicitudes.Location = New System.Drawing.Point(0, 66)
        Me.grdSolicitudes.Name = "grdSolicitudes"
        Me.grdSolicitudes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSolicitudes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSolicitudes.PreviewInfo.ZoomFactor = 75
        Me.grdSolicitudes.PrintInfo.PageSettings = CType(resources.GetObject("grdSolicitudes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSolicitudes.Size = New System.Drawing.Size(708, 371)
        Me.grdSolicitudes.TabIndex = 105
        Me.grdSolicitudes.Text = "C1TrueDBGrid1"
        Me.grdSolicitudes.PropBag = resources.GetString("grdSolicitudes.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 476)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 21)
        Me.Panel1.TabIndex = 102
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 32)
        Me.Panel2.TabIndex = 101
        Me.Panel2.Tag = "LAYOUT"
        '
        'toolAlertas
        '
        Me.toolAlertas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolAlertas.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolAlertas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbRefrescar, Me.ToolStripSeparator2, Me.tsbSalir})
        Me.toolAlertas.Location = New System.Drawing.Point(0, 32)
        Me.toolAlertas.Name = "toolAlertas"
        Me.toolAlertas.Size = New System.Drawing.Size(711, 31)
        Me.toolAlertas.TabIndex = 107
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(28, 28)
        Me.tsbRefrescar.Text = "Refrescar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(28, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdAnular)
        Me.Panel3.Controls.Add(Me.cmdConsultar)
        Me.Panel3.Controls.Add(Me.cmdAutorizar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 440)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(711, 36)
        Me.Panel3.TabIndex = 108
        '
        'cmdAnular
        '
        Me.cmdAnular.Location = New System.Drawing.Point(205, 3)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(95, 27)
        Me.cmdAnular.TabIndex = 109
        Me.cmdAnular.Text = "Anular"
        Me.cmdAnular.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(104, 3)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(95, 27)
        Me.cmdConsultar.TabIndex = 108
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.Location = New System.Drawing.Point(3, 3)
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(95, 27)
        Me.cmdAutorizar.TabIndex = 107
        Me.cmdAutorizar.Text = "Autorizar"
        Me.cmdAutorizar.UseVisualStyleBackColor = True
        '
        'frmAlertaSolicitudRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 497)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.toolAlertas)
        Me.Controls.Add(Me.grdSolicitudes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAlertaSolicitudRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta Gerencia / Responsable Taller."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.toolAlertas.ResumeLayout(False)
        Me.toolAlertas.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grdSolicitudes As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents toolAlertas As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdAnular As System.Windows.Forms.Button
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents cmdAutorizar As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
