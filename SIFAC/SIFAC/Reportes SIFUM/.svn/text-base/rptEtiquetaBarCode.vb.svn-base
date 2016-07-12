'-- Autor: Gelmin Martínez
'-- Fecha: 26 Julio 2010, 11:20 am. 
'-- Reporte para imprimir etiqueta de código de barra de repuesto.

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
'Imports System.IO 'Manipulación de archivos 
'Imports System.Drawing.Text 'Para dibujo de letra a través de fuente.

Public Class rptEtiquetaBarCode
    'Private FuenteCB As Font
    Private m_SivRepuestoCodigoBarras As String

    Public Property SivRepuestoCodigoBarras() As String
        Get
            SivRepuestoCodigoBarras = Me.m_SivRepuestoCodigoBarras
        End Get
        Set(ByVal value As String)
            Me.m_SivRepuestoCodigoBarras = value
        End Set
    End Property

    Private Sub rptEtiquetaBarCode_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        'Me.CargarFuente()
        'If Not (Me.FuenteCB Is Nothing) Then
        'Me.lblBarCodebyFuente.Font = Me.FuenteCB
        'End If

        Me.brCodigo.Text = Me.SivRepuestoCodigoBarras   'Código en Barras por medio de etiqueta barcode
        Me.txtCodigoRepuesto.Text = Me.SivRepuestoCodigoBarras 'Código en letras
        'Me.lblBarCodebyFuente.Text = Me.SivRepuestoCodigoBarras 'Código en barras por medio de fuente
    End Sub

    'Private Sub CargarFuente()
    '    Dim MiCollecciondeFuentes As New PrivateFontCollection()
    '    'cargamos la fuente el archivo esta en Debug\bin
    '    If (File.Exists(Application.StartupPath & "\FRE3OF9X.TTF")) Then
    '        MiCollecciondeFuentes.AddFontFile(Application.StartupPath & "\FRE3OF9X.TTF")
    '        Dim FamiliaDeFuentes As FontFamily = MiCollecciondeFuentes.Families(0)
    '        'llamamos al constructor de la clase font, donde le pasamos como 
    '        'parametros la familia de fuentes y el tamaño que tendra la fuente
    '        Me.FuenteCB = New Font(FamiliaDeFuentes, 36)
    '    End If
    'End Sub
End Class
