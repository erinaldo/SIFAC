'-- Clase para procedimientos y funciones globales usadas en reportes
'-- Autor: Gelmin Martínez, 
'-- Fecha creación :14 Junio 2010, 11:28 am.

Imports DataDynamics.ActiveReports

Public Class clsReportes

#Region "Enmarcar"
    ''' <summary>
    ''' Procedimiento para crear borde en los cuatro lados de una etiqueta de active Report
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:28 am.
    ''' </summary>
    ''' <param name="etiqueta">Etiqueta (Label) de Active report que desea enmarcar</param>
    Public Overloads Shared Sub Enmarcar(ByRef etiqueta As DataDynamics.ActiveReports.Label)
        Enmarcar(etiqueta, Nothing)
    End Sub

    ''' <summary>
    ''' Procedimiento para crear borde en los cuatro lados de una etiqueta de active Report
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:28 am.
    ''' </summary>
    ''' <param name="etiqueta">Etiqueta (Label) de Active report que desea enmarcar</param>
    ''' <param name="Color">Color que desea dar al borde </param>
    Public Overloads Shared Sub Enmarcar(ByRef etiqueta As DataDynamics.ActiveReports.Label, ByVal Color As System.Drawing.Color)
        With etiqueta.Border
            .TopStyle = BorderLineStyle.Solid
            .BottomStyle = BorderLineStyle.Solid
            .LeftStyle = BorderLineStyle.Solid
            .RightStyle = BorderLineStyle.Solid
        End With
        If Not Color = Nothing Then
            etiqueta.Border.Color = Color
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento para crear borde en los cuatro lados de un textbox de ActiveReport
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:28 am.
    ''' </summary>
    ''' <param name="Textbox">Textbox de Active report que desea enmarcar</param>
    Public Overloads Shared Sub Enmarcar(ByRef Textbox As DataDynamics.ActiveReports.TextBox)
        Enmarcar(Textbox, Nothing)
    End Sub

    ''' <summary>
    ''' Procedimiento para crear borde en los cuatro lados de un textbox de ActiveReport
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:28 am.
    ''' </summary>
    ''' <param name="Textbox">Textbox de Active report que desea enmarcar</param>
    ''' <param name="Color">Color que desea dar al borde</param>
    Public Overloads Shared Sub Enmarcar(ByRef Textbox As DataDynamics.ActiveReports.TextBox, ByVal color As System.Drawing.Color)
        With Textbox.Border
            .TopStyle = BorderLineStyle.Solid
            .BottomStyle = BorderLineStyle.Solid
            .LeftStyle = BorderLineStyle.Solid
            .RightStyle = BorderLineStyle.Solid
        End With
        If Not color = Nothing Then
            Textbox.Border.Color = color
        End If
    End Sub
#End Region

#Region "Borde Superior"
    ''' <summary>
    ''' Procedimiento para crear borde en la parte superior de un textbox de ActiveReport
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:53 am.
    ''' </summary>
    ''' <param name="Textbox">Textbox de Active report en el cual se dibujará el borde superior</param>
    Public Overloads Shared Sub BordeSuperior(ByRef Textbox As DataDynamics.ActiveReports.TextBox)
        BordeSuperior(Textbox, Nothing)
    End Sub

    ''' <summary>
    ''' Procedimiento para crear borde en la parte superior de un textbox de ActiveReport
    ''' Autor: Gelmin Martínez, 14 Junio 2010, 11:53 am.
    ''' </summary>
    ''' <param name="Textbox">Textbox de Active report en el cual se dibujará el borde superior</param>
    ''' <param name="color">Color que desea dar al borde superior</param>
    Public Overloads Shared Sub BordeSuperior(ByRef Textbox As DataDynamics.ActiveReports.TextBox, ByVal color As System.Drawing.Color)
        With Textbox
            .Border.TopStyle = BorderLineStyle.Solid
            If color <> Nothing Then
                .Border.Color = color
            End If
        End With
    End Sub
#End Region

End Class
