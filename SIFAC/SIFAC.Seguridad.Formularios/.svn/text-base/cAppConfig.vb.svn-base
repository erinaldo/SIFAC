'*************************************************************************************
'       Realizado por:      Yessica Flores Castro
'       Fecha        :      30/07/2007
'       Descripción  :      En esta clase se manipula el archivo de configuracion que  
'                           trae el Visual Studio.2005. Permite Configura y leer los 
'                           parametros establecidos en él (app.config)
'*************************************************************************************
Imports System
Imports System.Web
Imports System.Xml
Imports System.Configuration
Imports System.Collections
Imports System.Reflection
Imports System.Diagnostics

''' <summary>
''' Este enum representa los dos tipos de archivos de configuracion en .net
''' WebConfig que corresponde al archivo de configuracion de Sitios Web
''' AppConfig que corresponde al archivo de configuracion de Aplicaciones de escritorio
''' </summary>
''' <remarks></remarks>
Public Enum ConfigFileType
    WebConfig
    AppConfig
End Enum

Public Class cAppConfig
    Inherits System.Configuration.AppSettingsReader

    Public docName As String = String.Empty
    Private node As XmlNode = Nothing
    Private _configType As Integer
    Public NombreAppa As String
    ''' <summary>
    ''' Esta propiedad retorna tipo de configuracion que se esta usando
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ConfigType() As Integer
        Get
            Return _configType
        End Get
        Set(ByVal Value As Integer)
            _configType = Value
        End Set
    End Property
    ''' <summary>
    ''' Esta funcion se encarga de setear el valor del archivo de configuracion
    ''' </summary>
    ''' <param name="key">Nombre de la llave que se configurara</param>
    ''' <param name="value">Valor de la llave que se configurara</param>
    ''' <returns>Retorna un valor booleando, True si se configuro de manera satisfactoria y 
    ''' False en caso contrario</returns>
    ''' <remarks></remarks>
    Public Function SetValue(ByVal key As String, ByVal value As String) As Boolean
        Dim cfgdoc As New XmlDocument()
        Call loadConfigDoc(cfgdoc)

        node = cfgdoc.SelectSingleNode("//appSettings")
        If node Is Nothing Then
            Throw New System.InvalidOperationException("appSettings section not found")
        End If

        Try
            Dim addElem As XmlElement = CType(node.SelectSingleNode("//add[@key='" + key + "']"), XmlElement)

            If Not addElem Is Nothing Then
                addElem.SetAttribute("value", value)
            Else
                Dim enTry As XmlElement = cfgdoc.CreateElement("add")
                enTry.SetAttribute("key", key)
                enTry.SetAttribute("value", value)
                node.AppendChild(enTry)
            End If
            Call saveConfigDoc(cfgdoc, docName)
            Return True
        Catch
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Este procedimiento se encarga de salvar el archivo de configuracion
    ''' </summary>
    ''' <param name="cfgDoc">Nombre del Documento</param>
    ''' <param name="cfgDocPath">Direccion del Archivo</param>
    ''' <remarks></remarks>
    Private Sub saveConfigDoc(ByVal cfgDoc As XmlDocument, ByVal cfgDocPath As String)
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(cfgDocPath, Nothing)
            writer.Formatting = Formatting.Indented
            cfgDoc.WriteTo(writer)
            writer.Flush()
            writer.Close()
            Return
        Catch
            Throw
        End Try
    End Sub
    ''' <summary>
    ''' Esta funcion se encarga de remover el elemento dentro del archivo de 
    ''' configuracion
    ''' </summary>
    ''' <param name="elementKey"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function removeElement(ByVal elementKey As String) As Boolean
        Try
            Dim cfgDoc As XmlDocument = New XmlDocument()
            loadConfigDoc(cfgDoc)
            ' recupero el nodo appSettings
            node = cfgDoc.SelectSingleNode("//appSettings")
            If node Is Nothing Then
                Throw New System.InvalidOperationException("appSettings section not found")
            End If
            ' XPath selecionamos el elemento "add" que contiene la clave a remover
            node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"))

            saveConfigDoc(cfgDoc, docName)
            Return True
        Catch
            Return False
        End Try

    End Function
    ''' <summary>
    ''' Esta funcion se encarga de Cargar el Archivo de configuracion
    ''' </summary>
    ''' <param name="cfgDoc">Nombre del Documento que se desea Cargar</param>
    ''' <returns>Retorna el Documento XML que se ha cargado</returns>
    ''' <remarks></remarks>

    Private Function loadConfigDoc(ByVal cfgDoc As XmlDocument) As XmlDocument
        Dim Asm As System.Reflection.Assembly
        ' cargamos el archivo de configuración
        If Convert.ToInt32(ConfigType) = Convert.ToInt32(ConfigFileType.AppConfig) Then
            'docName = ((Asm.GetEntryAssembly()).GetName()).Name
            docName = Me.NombreAppa
            docName += ".config"
        Else
            'docName = System.Web.HttpContext.Current.Server.MapPath("web.config")
        End If
        cfgDoc.Load(docName)
        Return cfgDoc
    End Function
End Class
