Imports System.IO
Imports System.Drawing.Text
Imports SCCUM.BO
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos
Imports DAL

''' <summary>
''' Formulario de etiquetado de códigos de barras a repuesto
''' Autor : Gelmin Martínez
''' Fecha :26 de Julio de 2010, 08:59 am.
''' </summary>
Public Class frmEtiquetarCB

#Region "Atributos"
    Private FuenteCB As Font
    Private m_SivRepuestoID As String
    Private m_SivRepuestoCodigoBarras As String
#End Region

#Region "Propiedades"
    Public Property SivRepuestoID() As String
        Get
            Return Me.m_SivRepuestoID
        End Get
        Set(ByVal value As String)
            Me.m_SivRepuestoID = value
        End Set
    End Property

    Public Property SivRepuestoCodigoBarras() As String
        Get
            SivRepuestoCodigoBarras = Me.m_SivRepuestoCodigoBarras
        End Get
        Set(ByVal value As String)
            Me.m_SivRepuestoCodigoBarras = value
        End Set
    End Property
#End Region

#Region "Cargar Formulario"
    Private Sub frmEtiquetarCB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)

        Try
            Me.txtPrefijo.Text = ClsCatalogos.GetValorParametro("BarCodePrefijoDefault")
            Me.txtPostFijo.Text = ClsCatalogos.GetValorParametro("BarCodeSufijoDefault")
        Catch ex As Exception
            Me.txtPrefijo.Text = "*"
            Me.txtPrefijo.Text = "*"
        End Try
        Me.txtSivRepuestoCodigoBarras.Text = Me.SivRepuestoID
        Me.AgregarPrefijoPostFijo()
        Me.CargarFuente()
        If Not (Me.FuenteCB Is Nothing) Then
            Me.lblBarCode.Font = Me.FuenteCB
        End If
    End Sub

#End Region

#Region "Eventos de controles"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.ImprimirEtiqueta()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtSivRepuestoID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSivRepuestoCodigoBarras.TextChanged, txtPrefijo.TextChanged, txtPostFijo.TextChanged
        If Not String.IsNullOrEmpty(Me.txtSivRepuestoCodigoBarras.Text.Trim) Then
            Me.AgregarPrefijoPostFijo()
        End If
    End Sub

    Private Sub chkLimite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrefijo.CheckedChanged
        Me.txtPrefijo.Enabled = Me.chkPrefijo.Checked
        Me.AgregarPrefijoPostFijo()
        If Not Me.txtPrefijo.Enabled Then
            Me.txtPrefijo.BackColor = Color.LightGoldenrodYellow
        Else
            Me.txtPrefijo.BackColor = Color.White
        End If
    End Sub

    Private Sub chkPostFijo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSuFijo.CheckedChanged
        Me.txtPostFijo.Enabled = Me.chkSuFijo.Checked
        Me.AgregarPrefijoPostFijo()
        If Not Me.txtPostFijo.Enabled Then
            Me.txtPostFijo.BackColor = Color.LightGoldenrodYellow
        Else
            Me.txtPostFijo.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Imprimir Etiqueta"

    Private Sub ImprimirEtiqueta()
        Dim objRptEtiqueta As New rptEtiquetaBarCode
        Dim objSivRepuesto As New SivRepuestos
        'Dim sSQL As String
        Dim T As New TransactionManager
        Try
            objRptEtiqueta.SivRepuestoCodigoBarras = Me.lblBarCode.Text.Trim
            T.BeginTran()
            'Actualizar Código de barras del repuesto
            objSivRepuesto.Retrieve(Me.SivRepuestoID)
            objSivRepuesto.CodigoBarras = objRptEtiqueta.SivRepuestoCodigoBarras
            objSivRepuesto.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objSivRepuesto.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objSivRepuesto.Update(T)
            T.CommitTran()

            'Imprimir etiqueta de códigos de barras en impresora configurada en utilitario de configuración.

            'If clsProyecto.ImpresoraBarCode.Trim.Length <> 0 Then
            '    Try
            '        If clsProyecto.EstaImpresoraInstalada(clsProyecto.ImpresoraBarCode) Then
            '            objRptEtiqueta.Document.Printer.PrinterName = clsProyecto.ImpresoraBarCode
            '            'objRptOrdenCompra.Document.Print(False, False)
            '            clsProyecto.ImprimirEnImpresora(objRptEtiqueta, True)
            '        Else
            '            If MsgBox("La impresora '" + clsProyecto.ImpresoraBarCode + "' configurada en el Utilitario, no se encuentra instalada en el Sistema Operativo o el nombre no se ha escrito correctamente, Se mostrará la orden en Vista Previa.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema) Then
            '                clsProyecto.ImprimirEnPantalla(objRptEtiqueta)
            '            End If
            '        End If
            '    Catch ex As Exception
            '        clsError.CaptarError(ex)
            '    End Try
            'Else
            '    MsgBox("La impresora de Códigos de Barras no ha sido configurada, se mostrará la Etiqueta en vista previa.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            '    clsProyecto.ImprimirEnPantalla(objRptEtiqueta)
            'End If

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objRptEtiqueta = Nothing
            objSivRepuesto = Nothing
            T = Nothing
        End Try

    End Sub
#End Region

#Region "Cargar Fuente"
    Private Sub CargarFuente()
        Dim MiCollecciondeFuentes As New PrivateFontCollection()
        'cargamos la fuente el archivo esta en Debug\bin
        If (File.Exists(Application.StartupPath & "\FRE3OF9X.TTF")) Then
            MiCollecciondeFuentes.AddFontFile(Application.StartupPath & "\FRE3OF9X.TTF")
            Dim FamiliaDeFuentes As FontFamily = MiCollecciondeFuentes.Families(0)
            'llamamos al constructor de la clase font, donde le pasamos como 
            'parametros la familia de fuentes y el tamaño que tendra la fuente
            Me.FuenteCB = New Font(FamiliaDeFuentes, 36)
        End If
    End Sub
#End Region

#Region "Agregar Prefijo Sufijo"
    Private Sub AgregarPrefijoPostFijo()
        'Agregar prefijo
        If Me.chkPrefijo.Checked Then
            Me.lblBarCode.Text = Me.txtPrefijo.Text.Trim & Me.txtSivRepuestoCodigoBarras.Text.Trim
        Else
            Me.lblBarCode.Text = Me.txtSivRepuestoCodigoBarras.Text.Trim
        End If
        'Agregar PostFijo
        If Me.chkSuFijo.Checked Then
            Me.lblBarCode.Text = Me.lblBarCode.Text & Me.txtPostFijo.Text.Trim
        End If
    End Sub
#End Region

End Class