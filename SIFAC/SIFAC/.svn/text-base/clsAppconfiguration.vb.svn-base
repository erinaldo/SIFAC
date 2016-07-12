
Imports System.Xml
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Configuration.ConfigurationManager

Public Class clsAppconfiguration

#Region "Objetos globales a la clase"

    Private ConfigAppSettings As ConfigXmlDocument
    Private Node As XmlNode = Nothing
    Private mNombreArchivo As String

#End Region

#Region "Propiedades"

    Public Property NombreArchivo() As String
        Get
            Return mNombreArchivo
        End Get
        Set(ByVal value As String)
            mNombreArchivo = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Retorna la configuración definida en la sección appSettings del archivo appconfig.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAppSettings() As NameValueCollection
        Try
            Return AppSettings
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Obtiene el valor asociado a la llave especificada
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Getkey(ByVal key As String) As String
        Try
            Return AppSettings.Get(key)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Establece el valor a la llave especificada
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>

    Public Sub Setkey(ByVal key As String, ByVal Value As String)
        Dim Elemento As XmlElement
        Try
            Me.ConfigAppSettings.Load(Me.NombreArchivo)
            Me.Node = Me.ConfigAppSettings.SelectSingleNode("//appSettings")

            '--- Obtener el elemento a actualizar
            Elemento = CType(Me.Node.SelectSingleNode("//add[@key='" + key + "']"), XmlElement)
            '--- sí el elemnto ya existe, actualizar su valor
            If Not Elemento Is Nothing Then
                Elemento.SetAttribute("value", Value)
            Else
                '--- Crear el elemento
                Elemento = Me.ConfigAppSettings.CreateElement("add")
                Elemento.SetAttribute("key", key)
                Elemento.SetAttribute("value", Value)
            End If

            '--- Actualizar el appconfig
            Me.Node.AppendChild(Elemento)
            Me.ConfigAppSettings.Save(Me.NombreArchivo)
            '---------------

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
