'-------------------------------------------------------------------------------
'-      Realizado por   =   Yessica Flores
'-      Fecha           =   23/08/2007
'-      Objetivo        =   Buscar un archivo App.config de las aplicaciones
'-                          cuyas claves se desean modificar
'-------------------------------------------------------------------------------
Imports System.Configuration
Imports System.Xml
Imports Proyecto.Configuracion


Public Class FrmConfig
    Dim m_BoolReinit As Boolean
#Region "Propiedades"
    Public Property BoolReinit() As Boolean
        Get
            BoolReinit = m_BoolReinit
        End Get
        Set(ByVal value As Boolean)
            m_BoolReinit = value
        End Set
    End Property

#End Region


#Region "Declaración de Variables y Objetos locales a este formulario"
    '-- DataTable que alimenta el grid con el contenido del Archivo de Configuración
    Dim dtbConfiguracion As DataTable
    '-- Variable que almacena el nombre del archivo de configuración que se desea modificar
    Private NombreDocumento As String
    '-- Clase que manipula el archivo de configuracion 
    Private clsAppConfiguracion As New cAppConfig
#End Region


#Region "Eventos del Formulario"
    ''' <summary>
    ''' Evento del Boton encargado de Examinar o buscar un archivo app.config
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        ofdExaminador.InitialDirectory = My.Application.Info.DirectoryPath
        If Me.ofdExaminador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Me.txtRuta.Text = Me.ofdExaminador.FileName
                Dim str() As String = ofdExaminador.FileName.Split("\")
                'MessageBox.Show(str(str.Length - 1))
                If Me.txtRuta.Text.Trim.Length > 0 Then
                    Me.CargarConfigDoc(str(str.Length - 1))
                    Me.btnGuardar.Enabled = True
                    If Me.dtbConfiguracion.Rows.Count > 0 Then Me.btnEliminar.Enabled = True
                End If



            Catch ex As Exception

            End Try
        End If
    End Sub
    ''' <summary>
    ''' Evento load del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.ofdExaminador.Filter = "Archivos de Configuración (*.config)|*.config"
        Me.ofdExaminador.Title = "Seleccione archivo de configuración."
    End Sub
    ''' <summary>
    ''' Evento del Boton cancelar del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Evento Guardar del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If MsgBox("¿Desea salvar los cambios?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, clsProyecto.SiglasSistema) = MsgBoxResult.Ok Then
                If Me.GuardarCambiosConfigDoc() Then
                    MsgBox("El archivo fue modificado exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    MsgBox("El sistema se reiniciará para hacer los cambios visibles.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    BoolReinit = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Evento click del Boton eliminar del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dtbConfiguracion.Rows.Count > 0 Then
            Me.dtbConfiguracion.Rows.RemoveAt(Me.grdClaves.Row)
            Me.btnEliminar.Enabled = True
        Else
            Me.btnEliminar.Enabled = False
        End If

    End Sub

#Region "Eventos del Grid"
    Private Sub grdClaves_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdClaves.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.grdClaves.Columns("Value").Value.ToString <> "" And Not Me.dtbConfiguracion.DefaultView(Me.dtbConfiguracion.DefaultView.Count - 1)("Key") Is Nothing Then
                Dim drw As DataRow
                drw = Me.dtbConfiguracion.NewRow
                drw("Key") = ""
                drw("Value") = ""
                Me.dtbConfiguracion.Rows.Add(drw)
                Me.grdClaves.Row = Me.grdClaves.Row + 1
                Me.grdClaves.Col = 0
            End If
        End If
    End Sub

#End Region
#End Region

#Region "Metodos Independientes"


    ''' <summary>
    ''' Este parametro se encarga de Cargar los valores almacenados en el 
    ''' archivo de App.config de la una aplicacion determinada
    ''' </summary>
    ''' <param name="strNombre">Ruta o nombre del archivo que se modificara</param>
    ''' <remarks></remarks>
    Private Sub CargarConfigDoc(ByVal strNombre As String)
        Try
            NombreDocumento = strNombre.Substring(0, strNombre.Length - 7)
            Me.dtbConfiguracion.Clear()
            Dim drw As DataRow
            Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(NombreDocumento)

            'MsgBox(config.FilePath)
            For Each llave As String In config.AppSettings.Settings.AllKeys
                If llave <> "connectionString" Then
                    drw = Me.dtbConfiguracion.NewRow
                    drw("Key") = llave
                    drw("Value") = config.AppSettings.Settings.Item(llave).Value
                    Me.dtbConfiguracion.Rows.Add(drw)
                Else
                    Dim strValor As String = config.AppSettings.Settings.Item(llave).Value
                    Dim strV(), strKey, strValue As String
                    Dim s() As String
                    Dim intIndice As Integer
                    strV = strValor.Split(";")
                    For intIndice = 0 To strV.Length - 1
                        s = strV(intIndice).Split("=")
                        Select Case s(0).Trim
                            Case "server"
                                strKey = "server"
                            Case "database"
                                strKey = "database"
                            Case "Password"
                                strKey = "Password"
                            Case "User ID"
                                strKey = "User ID"
                            Case "Integrated Security"
                                strKey = "Integrated Security"
                        End Select
                        If Not String.IsNullOrEmpty(strKey) Then
                            drw = Me.dtbConfiguracion.NewRow
                            drw("Key") = strKey
                            drw("Value") = s(1)
                            Me.dtbConfiguracion.Rows.Add(drw)
                        End If
                        strKey = ""
                    Next
                End If
            Next
            'Me.grdClaves.DataSource = Me.dtbConfiguracion.DefaultView
            Me.grdClaves.SetDataBinding(Me.dtbConfiguracion, "", True)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Este metodo se encarga de salvar los cambios en el archivo que se encuentra
    ''' actualmente cargado
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GuardarCambiosConfigDoc() As Boolean
        Try
            Dim strCadenaConexion, strValor, strClave As String
            Dim intParametros As Integer = 0
            Me.clsAppConfiguracion.NombreAppa = NombreDocumento
            Me.clsAppConfiguracion.ConfigType = Convert.ToInt32(ConfigFileType.AppConfig)
            Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(NombreDocumento)
            For Each llave As String In config.AppSettings.Settings.AllKeys
                Me.clsAppConfiguracion.removeElement(llave)
            Next

            strCadenaConexion = ""
            strValor = ""
            strClave = ""
            For Each drv As DataRowView In Me.dtbConfiguracion.DefaultView
                If (Not drv("Key") Is Nothing) And (Not drv("Value") Is Nothing) Then
                    Select Case drv("Key").ToString.Trim
                        Case "server", "database", "Password", "User ID", "Integrated Security"
                            If strCadenaConexion <> "" Then strCadenaConexion = strCadenaConexion + ";" + drv("Key").ToString + "=" + drv("Value").ToString
                            If strCadenaConexion = "" Then strCadenaConexion = drv("Key").ToString + "=" + drv("Value").ToString
                            strClave = "connectionString"
                            strValor = strCadenaConexion
                        Case Else
                            strClave = drv("Key")
                            strValor = drv("Value")
                    End Select
                    Me.clsAppConfiguracion.SetValue(strClave, strValor)
                End If
            Next          
           
            Return True

        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

#End Region

#Region "Metodo de Inicialización del formulario"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dtbConfiguracion = New DataTable
        Me.dtbConfiguracion.Columns.Add("Key")
        Me.dtbConfiguracion.Columns.Add("Value")

        Me.dtbConfiguracion.Columns("Key").DataType = Type.GetType("System.String")
        Me.dtbConfiguracion.Columns("Value").DataType = Type.GetType("System.String")

    End Sub
#End Region




End Class
