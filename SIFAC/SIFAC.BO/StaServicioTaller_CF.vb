Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class StaServicioTaller		

#Region " Variables Miembro " 
	Protected m_StaServicioTallerID As Integer 
	Protected m_objSccCuentaID As String = Nothing 
	Protected m_objSccCuentaTiendaID As Nullable(Of Integer) 
	Protected m_objServicioTiendaID As Integer 
	Protected m_objClienteID As String = Nothing 
	Protected m_objTipoServicioID As Integer 
	Protected m_objEstadoServicioID As Integer 
	Protected m_objTecnicoAsignadoID As Integer 
	Protected m_FechaRecibida As Date 
	Protected m_objNivelCombustibleID As Integer 
	Protected m_objTipoKilometrajeID As Integer 
	Protected m_ValorKilometraje As Integer 
	Protected m_ModeloMoto As String = Nothing 
	Protected m_MarcaMoto As String = Nothing 
	Protected m_NoMotorMoto As String = Nothing 
	Protected m_ChasisMoto As String = Nothing 
	Protected m_PlacaMoto As String = Nothing 
	Protected m_ColorMoto As String = Nothing 
	Protected m_ServicioGarantia As Nullable(Of Boolean) 
	Protected m_CantidadServiciosGarantia As Nullable(Of Integer) 
	Protected m_ObservacionesJefeTaller As String = Nothing 
	Protected m_FallasReportadasCliente As String = Nothing 
	Protected m_MotoRecibidaDe As String = Nothing 
	Protected m_CambioAceite As Nullable(Of Boolean) 
	Protected m_LimpiezaCarburador As Nullable(Of Boolean) 
	Protected m_AjusteFrenos As Nullable(Of Boolean) 
	Protected m_AjusteCadenaSecundaria As Nullable(Of Boolean) 
	Protected m_ChequeoTiempoEncendido As Nullable(Of Boolean) 
	Protected m_ChequeoBateria As Nullable(Of Boolean) 
	Protected m_RegulacionEmbrague As Nullable(Of Boolean) 
	Protected m_CalibrarValvulas As Nullable(Of Boolean) 
	Protected m_EngraseEjeSuspensionTrasera As Nullable(Of Boolean) 
	Protected m_EngraseEjeDelanteroTrasero As Nullable(Of Boolean) 
	Protected m_CambioFricciones As Nullable(Of Boolean) 
	Protected m_Otros As String = Nothing 
	Protected m_FechaEntrega As Nullable(Of Date) 
	Protected m_DiagnosticoTaller As String = Nothing 
	Protected m_Solucion As String = Nothing 
	Protected m_MotoEntregadaA As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property StaServicioTallerID() As Integer
        Get
            Return (m_StaServicioTallerID)
        End Get
		Set(ByVal Value As Integer)					
			m_StaServicioTallerID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As String
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("objSccCuentaID", Value.ToString(), "Valor inv?lido para StaServicioTaller.objSccCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property objSccCuentaTiendaID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaTiendaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaTiendaID = Value
		End Set
    End Property
	
	Public Property objServicioTiendaID() As Integer
        Get
            Return (m_objServicioTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objServicioTiendaID = Value
		End Set
    End Property
	
	Public Property objClienteID() As String
        Get
            Return (m_objClienteID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("objClienteID", Value.ToString(), "Valor inv?lido para StaServicioTaller.objClienteID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_objClienteID = Value
		End Set
    End Property
	
	Public Property objTipoServicioID() As Integer
        Get
            Return (m_objTipoServicioID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTipoServicioID = Value
		End Set
    End Property
	
	Public Property objEstadoServicioID() As Integer
        Get
            Return (m_objEstadoServicioID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoServicioID = Value
		End Set
    End Property
	
	Public Property objTecnicoAsignadoID() As Integer
        Get
            Return (m_objTecnicoAsignadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTecnicoAsignadoID = Value
		End Set
    End Property
	
	Public Property FechaRecibida() As Date
        Get
            Return (m_FechaRecibida)
        End Get
		Set(ByVal Value As Date)					
			m_FechaRecibida = Value
		End Set
    End Property
	
	Public Property objNivelCombustibleID() As Integer
        Get
            Return (m_objNivelCombustibleID)
        End Get
		Set(ByVal Value As Integer)					
			m_objNivelCombustibleID = Value
		End Set
    End Property
	
	Public Property objTipoKilometrajeID() As Integer
        Get
            Return (m_objTipoKilometrajeID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTipoKilometrajeID = Value
		End Set
    End Property
	
	Public Property ValorKilometraje() As Integer
        Get
            Return (m_ValorKilometraje)
        End Get
		Set(ByVal Value As Integer)					
			m_ValorKilometraje = Value
		End Set
    End Property
	
	Public Property ModeloMoto() As String
        Get
            Return (m_ModeloMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("ModeloMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.ModeloMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_ModeloMoto = Value
		End Set
    End Property
	
	Public Property MarcaMoto() As String
        Get
            Return (m_MarcaMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 40 Then
					Throw New ArgumentOutOfRangeException("MarcaMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.MarcaMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (40).")
				End If
			End If
			m_MarcaMoto = Value
		End Set
    End Property
	
	Public Property NoMotorMoto() As String
        Get
            Return (m_NoMotorMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("NoMotorMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.NoMotorMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_NoMotorMoto = Value
		End Set
    End Property
	
	Public Property ChasisMoto() As String
        Get
            Return (m_ChasisMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("ChasisMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.ChasisMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_ChasisMoto = Value
		End Set
    End Property
	
	Public Property PlacaMoto() As String
        Get
            Return (m_PlacaMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 20 Then
					Throw New ArgumentOutOfRangeException("PlacaMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.PlacaMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (20).")
				End If
			End If
			m_PlacaMoto = Value
		End Set
    End Property
	
	Public Property ColorMoto() As String
        Get
            Return (m_ColorMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("ColorMoto", Value.ToString(), "Valor inv?lido para StaServicioTaller.ColorMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_ColorMoto = Value
		End Set
    End Property
	
	Public Property ServicioGarantia() As Nullable(Of Boolean)
        Get
            Return (m_ServicioGarantia)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_ServicioGarantia = Value
		End Set
    End Property
	
	Public Property CantidadServiciosGarantia() As Nullable(Of Integer)
        Get
            Return (m_CantidadServiciosGarantia)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_CantidadServiciosGarantia = Value
		End Set
    End Property
	
	Public Property ObservacionesJefeTaller() As String
        Get
            Return (m_ObservacionesJefeTaller)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("ObservacionesJefeTaller", Value.ToString(), "Valor inv?lido para StaServicioTaller.ObservacionesJefeTaller. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_ObservacionesJefeTaller = Value
		End Set
    End Property
	
	Public Property FallasReportadasCliente() As String
        Get
            Return (m_FallasReportadasCliente)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("FallasReportadasCliente", Value.ToString(), "Valor inv?lido para StaServicioTaller.FallasReportadasCliente. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_FallasReportadasCliente = Value
		End Set
    End Property
	
	Public Property MotoRecibidaDe() As String
        Get
            Return (m_MotoRecibidaDe)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("MotoRecibidaDe", Value.ToString(), "Valor inv?lido para StaServicioTaller.MotoRecibidaDe. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_MotoRecibidaDe = Value
		End Set
    End Property
	
	Public Property CambioAceite() As Nullable(Of Boolean)
        Get
            Return (m_CambioAceite)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CambioAceite = Value
		End Set
    End Property
	
	Public Property LimpiezaCarburador() As Nullable(Of Boolean)
        Get
            Return (m_LimpiezaCarburador)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_LimpiezaCarburador = Value
		End Set
    End Property
	
	Public Property AjusteFrenos() As Nullable(Of Boolean)
        Get
            Return (m_AjusteFrenos)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_AjusteFrenos = Value
		End Set
    End Property
	
	Public Property AjusteCadenaSecundaria() As Nullable(Of Boolean)
        Get
            Return (m_AjusteCadenaSecundaria)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_AjusteCadenaSecundaria = Value
		End Set
    End Property
	
	Public Property ChequeoTiempoEncendido() As Nullable(Of Boolean)
        Get
            Return (m_ChequeoTiempoEncendido)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_ChequeoTiempoEncendido = Value
		End Set
    End Property
	
	Public Property ChequeoBateria() As Nullable(Of Boolean)
        Get
            Return (m_ChequeoBateria)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_ChequeoBateria = Value
		End Set
    End Property
	
	Public Property RegulacionEmbrague() As Nullable(Of Boolean)
        Get
            Return (m_RegulacionEmbrague)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_RegulacionEmbrague = Value
		End Set
    End Property
	
	Public Property CalibrarValvulas() As Nullable(Of Boolean)
        Get
            Return (m_CalibrarValvulas)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CalibrarValvulas = Value
		End Set
    End Property
	
	Public Property EngraseEjeSuspensionTrasera() As Nullable(Of Boolean)
        Get
            Return (m_EngraseEjeSuspensionTrasera)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_EngraseEjeSuspensionTrasera = Value
		End Set
    End Property
	
	Public Property EngraseEjeDelanteroTrasero() As Nullable(Of Boolean)
        Get
            Return (m_EngraseEjeDelanteroTrasero)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_EngraseEjeDelanteroTrasero = Value
		End Set
    End Property
	
	Public Property CambioFricciones() As Nullable(Of Boolean)
        Get
            Return (m_CambioFricciones)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CambioFricciones = Value
		End Set
    End Property
	
	Public Property Otros() As String
        Get
            Return (m_Otros)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Otros", Value.ToString(), "Valor inv?lido para StaServicioTaller.Otros. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Otros = Value
		End Set
    End Property
	
	Public Property FechaEntrega() As Nullable(Of Date)
        Get
            Return (m_FechaEntrega)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaEntrega = Value
		End Set
    End Property
	
	Public Property DiagnosticoTaller() As String
        Get
            Return (m_DiagnosticoTaller)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("DiagnosticoTaller", Value.ToString(), "Valor inv?lido para StaServicioTaller.DiagnosticoTaller. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_DiagnosticoTaller = Value
		End Set
    End Property
	
	Public Property Solucion() As String
        Get
            Return (m_Solucion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("Solucion", Value.ToString(), "Valor inv?lido para StaServicioTaller.Solucion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_Solucion = Value
		End Set
    End Property
	
	Public Property MotoEntregadaA() As String
        Get
            Return (m_MotoEntregadaA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("MotoEntregadaA", Value.ToString(), "Valor inv?lido para StaServicioTaller.MotoEntregadaA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_MotoEntregadaA = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StaServicioTaller.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StaServicioTaller.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objSccCuentaID"
				Return	15
			Case "objClienteID"
				Return	16
			Case "ModeloMoto"
				Return	50
			Case "MarcaMoto"
				Return	40
			Case "NoMotorMoto"
				Return	100
			Case "ChasisMoto"
				Return	100
			Case "PlacaMoto"
				Return	20
			Case "ColorMoto"
				Return	50
			Case "ObservacionesJefeTaller"
				Return	500
			Case "FallasReportadasCliente"
				Return	500
			Case "MotoRecibidaDe"
				Return	50
			Case "Otros"
				Return	255
			Case "DiagnosticoTaller"
				Return	500
			Case "Solucion"
				Return	500
			Case "MotoEntregadaA"
				Return	50
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla StaServicioTaller en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StaServicioTaller </param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo BatchUpdate.</param>
    ''' <remarks>Usado para realizar actualizaciones en Batch.</remarks>
	public Shared Sub BatchUpdate( DS as Dataset, optional Byval pTransac as TransactionManager = Nothing )
	    Dim cmdInsert As SqlCommand = Nothing
        Dim cmdUpdate As SqlCommand = Nothing
        Dim cmdDelete As SqlCommand = Nothing
		
		Try
			cmdInsert = New SqlCommand
			cmdUpdate = New SqlCommand
			cmdDelete = New SqlCommand
			'CREACION DEL COMANDO DELETE
			cmdDelete.Parameters.Add("@StaServicioTallerID", SqlDbType.Int, 4, "StaServicioTallerID" )
			cmdDelete.CommandText = "DELETE FROM  StaServicioTaller WHERE StaServicioTallerID= @StaServicioTallerID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objSccCuentaTiendaID", SqlDbType.Int, 4, "objSccCuentaTiendaID")
			cmdInsert.Parameters.Add("@objServicioTiendaID", SqlDbType.Int, 4, "objServicioTiendaID")
			cmdInsert.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdInsert.Parameters.Add("@objTipoServicioID", SqlDbType.Int, 4, "objTipoServicioID")
			cmdInsert.Parameters.Add("@objEstadoServicioID", SqlDbType.Int, 4, "objEstadoServicioID")
			cmdInsert.Parameters.Add("@objTecnicoAsignadoID", SqlDbType.Int, 4, "objTecnicoAsignadoID")
			cmdInsert.Parameters.Add("@FechaRecibida", SqlDbType.DateTime, 8, "FechaRecibida")
			cmdInsert.Parameters.Add("@objNivelCombustibleID", SqlDbType.Int, 4, "objNivelCombustibleID")
			cmdInsert.Parameters.Add("@objTipoKilometrajeID", SqlDbType.Int, 4, "objTipoKilometrajeID")
			cmdInsert.Parameters.Add("@ValorKilometraje", SqlDbType.Int, 4, "ValorKilometraje")
			cmdInsert.Parameters.Add("@ModeloMoto", SqlDbType.VarChar, 50, "ModeloMoto")
			cmdInsert.Parameters.Add("@MarcaMoto", SqlDbType.VarChar, 40, "MarcaMoto")
			cmdInsert.Parameters.Add("@NoMotorMoto", SqlDbType.VarChar, 100, "NoMotorMoto")
			cmdInsert.Parameters.Add("@ChasisMoto", SqlDbType.VarChar, 100, "ChasisMoto")
			cmdInsert.Parameters.Add("@PlacaMoto", SqlDbType.VarChar, 20, "PlacaMoto")
			cmdInsert.Parameters.Add("@ColorMoto", SqlDbType.VarChar, 50, "ColorMoto")
			cmdInsert.Parameters.Add("@ServicioGarantia", SqlDbType.Bit, 1, "ServicioGarantia")
			cmdInsert.Parameters.Add("@CantidadServiciosGarantia", SqlDbType.Int, 4, "CantidadServiciosGarantia")
			cmdInsert.Parameters.Add("@ObservacionesJefeTaller", SqlDbType.VarChar, 500, "ObservacionesJefeTaller")
			cmdInsert.Parameters.Add("@FallasReportadasCliente", SqlDbType.VarChar, 500, "FallasReportadasCliente")
			cmdInsert.Parameters.Add("@MotoRecibidaDe", SqlDbType.VarChar, 50, "MotoRecibidaDe")
			cmdInsert.Parameters.Add("@CambioAceite", SqlDbType.Bit, 1, "CambioAceite")
			cmdInsert.Parameters.Add("@LimpiezaCarburador", SqlDbType.Bit, 1, "LimpiezaCarburador")
			cmdInsert.Parameters.Add("@AjusteFrenos", SqlDbType.Bit, 1, "AjusteFrenos")
			cmdInsert.Parameters.Add("@AjusteCadenaSecundaria", SqlDbType.Bit, 1, "AjusteCadenaSecundaria")
			cmdInsert.Parameters.Add("@ChequeoTiempoEncendido", SqlDbType.Bit, 1, "ChequeoTiempoEncendido")
			cmdInsert.Parameters.Add("@ChequeoBateria", SqlDbType.Bit, 1, "ChequeoBateria")
			cmdInsert.Parameters.Add("@RegulacionEmbrague", SqlDbType.Bit, 1, "RegulacionEmbrague")
			cmdInsert.Parameters.Add("@CalibrarValvulas", SqlDbType.Bit, 1, "CalibrarValvulas")
			cmdInsert.Parameters.Add("@EngraseEjeSuspensionTrasera", SqlDbType.Bit, 1, "EngraseEjeSuspensionTrasera")
			cmdInsert.Parameters.Add("@EngraseEjeDelanteroTrasero", SqlDbType.Bit, 1, "EngraseEjeDelanteroTrasero")
			cmdInsert.Parameters.Add("@CambioFricciones", SqlDbType.Bit, 1, "CambioFricciones")
			cmdInsert.Parameters.Add("@Otros", SqlDbType.VarChar, 255, "Otros")
			cmdInsert.Parameters.Add("@FechaEntrega", SqlDbType.DateTime, 8, "FechaEntrega")
			cmdInsert.Parameters.Add("@DiagnosticoTaller", SqlDbType.VarChar, 500, "DiagnosticoTaller")
			cmdInsert.Parameters.Add("@Solucion", SqlDbType.VarChar, 500, "Solucion")
			cmdInsert.Parameters.Add("@MotoEntregadaA", SqlDbType.VarChar, 50, "MotoEntregadaA")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO StaServicioTaller ( objSccCuentaID, objSccCuentaTiendaID, objServicioTiendaID, objClienteID, objTipoServicioID, objEstadoServicioID, objTecnicoAsignadoID, FechaRecibida, objNivelCombustibleID, objTipoKilometrajeID, ValorKilometraje, ModeloMoto, MarcaMoto, NoMotorMoto, ChasisMoto, PlacaMoto, ColorMoto, ServicioGarantia, CantidadServiciosGarantia, ObservacionesJefeTaller, FallasReportadasCliente, MotoRecibidaDe, CambioAceite, LimpiezaCarburador, AjusteFrenos, AjusteCadenaSecundaria, ChequeoTiempoEncendido, ChequeoBateria, RegulacionEmbrague, CalibrarValvulas, EngraseEjeSuspensionTrasera, EngraseEjeDelanteroTrasero, CambioFricciones, Otros, FechaEntrega, DiagnosticoTaller, Solucion, MotoEntregadaA, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objSccCuentaID, @objSccCuentaTiendaID, @objServicioTiendaID, @objClienteID, @objTipoServicioID, @objEstadoServicioID, @objTecnicoAsignadoID, @FechaRecibida, @objNivelCombustibleID, @objTipoKilometrajeID, @ValorKilometraje, @ModeloMoto, @MarcaMoto, @NoMotorMoto, @ChasisMoto, @PlacaMoto, @ColorMoto, @ServicioGarantia, @CantidadServiciosGarantia, @ObservacionesJefeTaller, @FallasReportadasCliente, @MotoRecibidaDe, @CambioAceite, @LimpiezaCarburador, @AjusteFrenos, @AjusteCadenaSecundaria, @ChequeoTiempoEncendido, @ChequeoBateria, @RegulacionEmbrague, @CalibrarValvulas, @EngraseEjeSuspensionTrasera, @EngraseEjeDelanteroTrasero, @CambioFricciones, @Otros, @FechaEntrega, @DiagnosticoTaller, @Solucion, @MotoEntregadaA, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objSccCuentaTiendaID", SqlDbType.Int, 4, "objSccCuentaTiendaID")
			cmdUpdate.Parameters.Add("@objServicioTiendaID", SqlDbType.Int, 4, "objServicioTiendaID")
			cmdUpdate.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdUpdate.Parameters.Add("@objTipoServicioID", SqlDbType.Int, 4, "objTipoServicioID")
			cmdUpdate.Parameters.Add("@objEstadoServicioID", SqlDbType.Int, 4, "objEstadoServicioID")
			cmdUpdate.Parameters.Add("@objTecnicoAsignadoID", SqlDbType.Int, 4, "objTecnicoAsignadoID")
			cmdUpdate.Parameters.Add("@FechaRecibida", SqlDbType.DateTime, 8, "FechaRecibida")
			cmdUpdate.Parameters.Add("@objNivelCombustibleID", SqlDbType.Int, 4, "objNivelCombustibleID")
			cmdUpdate.Parameters.Add("@objTipoKilometrajeID", SqlDbType.Int, 4, "objTipoKilometrajeID")
			cmdUpdate.Parameters.Add("@ValorKilometraje", SqlDbType.Int, 4, "ValorKilometraje")
			cmdUpdate.Parameters.Add("@ModeloMoto", SqlDbType.VarChar, 50, "ModeloMoto")
			cmdUpdate.Parameters.Add("@MarcaMoto", SqlDbType.VarChar, 40, "MarcaMoto")
			cmdUpdate.Parameters.Add("@NoMotorMoto", SqlDbType.VarChar, 100, "NoMotorMoto")
			cmdUpdate.Parameters.Add("@ChasisMoto", SqlDbType.VarChar, 100, "ChasisMoto")
			cmdUpdate.Parameters.Add("@PlacaMoto", SqlDbType.VarChar, 20, "PlacaMoto")
			cmdUpdate.Parameters.Add("@ColorMoto", SqlDbType.VarChar, 50, "ColorMoto")
			cmdUpdate.Parameters.Add("@ServicioGarantia", SqlDbType.Bit, 1, "ServicioGarantia")
			cmdUpdate.Parameters.Add("@CantidadServiciosGarantia", SqlDbType.Int, 4, "CantidadServiciosGarantia")
			cmdUpdate.Parameters.Add("@ObservacionesJefeTaller", SqlDbType.VarChar, 500, "ObservacionesJefeTaller")
			cmdUpdate.Parameters.Add("@FallasReportadasCliente", SqlDbType.VarChar, 500, "FallasReportadasCliente")
			cmdUpdate.Parameters.Add("@MotoRecibidaDe", SqlDbType.VarChar, 50, "MotoRecibidaDe")
			cmdUpdate.Parameters.Add("@CambioAceite", SqlDbType.Bit, 1, "CambioAceite")
			cmdUpdate.Parameters.Add("@LimpiezaCarburador", SqlDbType.Bit, 1, "LimpiezaCarburador")
			cmdUpdate.Parameters.Add("@AjusteFrenos", SqlDbType.Bit, 1, "AjusteFrenos")
			cmdUpdate.Parameters.Add("@AjusteCadenaSecundaria", SqlDbType.Bit, 1, "AjusteCadenaSecundaria")
			cmdUpdate.Parameters.Add("@ChequeoTiempoEncendido", SqlDbType.Bit, 1, "ChequeoTiempoEncendido")
			cmdUpdate.Parameters.Add("@ChequeoBateria", SqlDbType.Bit, 1, "ChequeoBateria")
			cmdUpdate.Parameters.Add("@RegulacionEmbrague", SqlDbType.Bit, 1, "RegulacionEmbrague")
			cmdUpdate.Parameters.Add("@CalibrarValvulas", SqlDbType.Bit, 1, "CalibrarValvulas")
			cmdUpdate.Parameters.Add("@EngraseEjeSuspensionTrasera", SqlDbType.Bit, 1, "EngraseEjeSuspensionTrasera")
			cmdUpdate.Parameters.Add("@EngraseEjeDelanteroTrasero", SqlDbType.Bit, 1, "EngraseEjeDelanteroTrasero")
			cmdUpdate.Parameters.Add("@CambioFricciones", SqlDbType.Bit, 1, "CambioFricciones")
			cmdUpdate.Parameters.Add("@Otros", SqlDbType.VarChar, 255, "Otros")
			cmdUpdate.Parameters.Add("@FechaEntrega", SqlDbType.DateTime, 8, "FechaEntrega")
			cmdUpdate.Parameters.Add("@DiagnosticoTaller", SqlDbType.VarChar, 500, "DiagnosticoTaller")
			cmdUpdate.Parameters.Add("@Solucion", SqlDbType.VarChar, 500, "Solucion")
			cmdUpdate.Parameters.Add("@MotoEntregadaA", SqlDbType.VarChar, 50, "MotoEntregadaA")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wStaServicioTallerID", SqlDbType.Int, 4, "StaServicioTallerID")
			cmdUpdate.CommandText = "UPDATE StaServicioTaller SET objSccCuentaID=@objSccCuentaID, objSccCuentaTiendaID=@objSccCuentaTiendaID, objServicioTiendaID=@objServicioTiendaID, objClienteID=@objClienteID, objTipoServicioID=@objTipoServicioID, objEstadoServicioID=@objEstadoServicioID, objTecnicoAsignadoID=@objTecnicoAsignadoID, FechaRecibida=@FechaRecibida, objNivelCombustibleID=@objNivelCombustibleID, objTipoKilometrajeID=@objTipoKilometrajeID, ValorKilometraje=@ValorKilometraje, ModeloMoto=@ModeloMoto, MarcaMoto=@MarcaMoto, NoMotorMoto=@NoMotorMoto, ChasisMoto=@ChasisMoto, PlacaMoto=@PlacaMoto, ColorMoto=@ColorMoto, ServicioGarantia=@ServicioGarantia, CantidadServiciosGarantia=@CantidadServiciosGarantia, ObservacionesJefeTaller=@ObservacionesJefeTaller, FallasReportadasCliente=@FallasReportadasCliente, MotoRecibidaDe=@MotoRecibidaDe, CambioAceite=@CambioAceite, LimpiezaCarburador=@LimpiezaCarburador, AjusteFrenos=@AjusteFrenos, AjusteCadenaSecundaria=@AjusteCadenaSecundaria, ChequeoTiempoEncendido=@ChequeoTiempoEncendido, ChequeoBateria=@ChequeoBateria, RegulacionEmbrague=@RegulacionEmbrague, CalibrarValvulas=@CalibrarValvulas, EngraseEjeSuspensionTrasera=@EngraseEjeSuspensionTrasera, EngraseEjeDelanteroTrasero=@EngraseEjeDelanteroTrasero, CambioFricciones=@CambioFricciones, Otros=@Otros, FechaEntrega=@FechaEntrega, DiagnosticoTaller=@DiagnosticoTaller, Solucion=@Solucion, MotoEntregadaA=@MotoEntregadaA, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE StaServicioTallerID= @wStaServicioTallerID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StaServicioTaller")
		Catch ex As Exception
            Throw
        Finally
            If Not cmdInsert Is Nothing Then
                cmdInsert.Dispose()
            End If
            If Not cmdUpdate Is Nothing Then
                cmdUpdate.Dispose()
            End If
            If Not cmdDelete Is Nothing Then
                cmdDelete.Dispose()
            End If
        End Try
	End Sub 
#End Region

#Region " Retrieve "
	''' <summary>
    ''' Devuelve de la base de datos un objeto StaServicioTaller
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StaServicioTallerID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StaServicioTaller where " & " StaServicioTallerID = " & p_StaServicioTallerID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_StaServicioTallerID = dr("StaServicioTallerID")
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSccCuentaTiendaID = IIf(IsDBNull(dr("objSccCuentaTiendaID")), Nothing, dr("objSccCuentaTiendaID"))					
				m_objServicioTiendaID = IIf(IsDBNull(dr("objServicioTiendaID")), Nothing, dr("objServicioTiendaID"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objTipoServicioID = IIf(IsDBNull(dr("objTipoServicioID")), Nothing, dr("objTipoServicioID"))					
				m_objEstadoServicioID = IIf(IsDBNull(dr("objEstadoServicioID")), Nothing, dr("objEstadoServicioID"))					
				m_objTecnicoAsignadoID = IIf(IsDBNull(dr("objTecnicoAsignadoID")), Nothing, dr("objTecnicoAsignadoID"))					
				m_FechaRecibida = IIf(IsDBNull(dr("FechaRecibida")), Nothing, dr("FechaRecibida"))					
				m_objNivelCombustibleID = IIf(IsDBNull(dr("objNivelCombustibleID")), Nothing, dr("objNivelCombustibleID"))					
				m_objTipoKilometrajeID = IIf(IsDBNull(dr("objTipoKilometrajeID")), Nothing, dr("objTipoKilometrajeID"))					
				m_ValorKilometraje = IIf(IsDBNull(dr("ValorKilometraje")), Nothing, dr("ValorKilometraje"))					
				m_ModeloMoto = IIf(IsDBNull(dr("ModeloMoto")), Nothing, dr("ModeloMoto"))					
				m_MarcaMoto = IIf(IsDBNull(dr("MarcaMoto")), Nothing, dr("MarcaMoto"))					
				m_NoMotorMoto = IIf(IsDBNull(dr("NoMotorMoto")), Nothing, dr("NoMotorMoto"))					
				m_ChasisMoto = IIf(IsDBNull(dr("ChasisMoto")), Nothing, dr("ChasisMoto"))					
				m_PlacaMoto = IIf(IsDBNull(dr("PlacaMoto")), Nothing, dr("PlacaMoto"))					
				m_ColorMoto = IIf(IsDBNull(dr("ColorMoto")), Nothing, dr("ColorMoto"))					
				m_ServicioGarantia = IIf(IsDBNull(dr("ServicioGarantia")), Nothing, dr("ServicioGarantia"))					
				m_CantidadServiciosGarantia = IIf(IsDBNull(dr("CantidadServiciosGarantia")), Nothing, dr("CantidadServiciosGarantia"))					
				m_ObservacionesJefeTaller = IIf(IsDBNull(dr("ObservacionesJefeTaller")), Nothing, dr("ObservacionesJefeTaller"))					
				m_FallasReportadasCliente = IIf(IsDBNull(dr("FallasReportadasCliente")), Nothing, dr("FallasReportadasCliente"))					
				m_MotoRecibidaDe = IIf(IsDBNull(dr("MotoRecibidaDe")), Nothing, dr("MotoRecibidaDe"))					
				m_CambioAceite = IIf(IsDBNull(dr("CambioAceite")), Nothing, dr("CambioAceite"))					
				m_LimpiezaCarburador = IIf(IsDBNull(dr("LimpiezaCarburador")), Nothing, dr("LimpiezaCarburador"))					
				m_AjusteFrenos = IIf(IsDBNull(dr("AjusteFrenos")), Nothing, dr("AjusteFrenos"))					
				m_AjusteCadenaSecundaria = IIf(IsDBNull(dr("AjusteCadenaSecundaria")), Nothing, dr("AjusteCadenaSecundaria"))					
				m_ChequeoTiempoEncendido = IIf(IsDBNull(dr("ChequeoTiempoEncendido")), Nothing, dr("ChequeoTiempoEncendido"))					
				m_ChequeoBateria = IIf(IsDBNull(dr("ChequeoBateria")), Nothing, dr("ChequeoBateria"))					
				m_RegulacionEmbrague = IIf(IsDBNull(dr("RegulacionEmbrague")), Nothing, dr("RegulacionEmbrague"))					
				m_CalibrarValvulas = IIf(IsDBNull(dr("CalibrarValvulas")), Nothing, dr("CalibrarValvulas"))					
				m_EngraseEjeSuspensionTrasera = IIf(IsDBNull(dr("EngraseEjeSuspensionTrasera")), Nothing, dr("EngraseEjeSuspensionTrasera"))					
				m_EngraseEjeDelanteroTrasero = IIf(IsDBNull(dr("EngraseEjeDelanteroTrasero")), Nothing, dr("EngraseEjeDelanteroTrasero"))					
				m_CambioFricciones = IIf(IsDBNull(dr("CambioFricciones")), Nothing, dr("CambioFricciones"))					
				m_Otros = IIf(IsDBNull(dr("Otros")), Nothing, dr("Otros"))					
				m_FechaEntrega = IIf(IsDBNull(dr("FechaEntrega")), Nothing, dr("FechaEntrega"))					
				m_DiagnosticoTaller = IIf(IsDBNull(dr("DiagnosticoTaller")), Nothing, dr("DiagnosticoTaller"))					
				m_Solucion = IIf(IsDBNull(dr("Solucion")), Nothing, dr("Solucion"))					
				m_MotoEntregadaA = IIf(IsDBNull(dr("MotoEntregadaA")), Nothing, dr("MotoEntregadaA"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Devuelve de la base de datos un objeto StaServicioTaller usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StaServicioTaller where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_StaServicioTallerID = dr("StaServicioTallerID")
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSccCuentaTiendaID = IIf(IsDBNull(dr("objSccCuentaTiendaID")), Nothing, dr("objSccCuentaTiendaID"))					
				m_objServicioTiendaID = IIf(IsDBNull(dr("objServicioTiendaID")), Nothing, dr("objServicioTiendaID"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objTipoServicioID = IIf(IsDBNull(dr("objTipoServicioID")), Nothing, dr("objTipoServicioID"))					
				m_objEstadoServicioID = IIf(IsDBNull(dr("objEstadoServicioID")), Nothing, dr("objEstadoServicioID"))					
				m_objTecnicoAsignadoID = IIf(IsDBNull(dr("objTecnicoAsignadoID")), Nothing, dr("objTecnicoAsignadoID"))					
				m_FechaRecibida = IIf(IsDBNull(dr("FechaRecibida")), Nothing, dr("FechaRecibida"))					
				m_objNivelCombustibleID = IIf(IsDBNull(dr("objNivelCombustibleID")), Nothing, dr("objNivelCombustibleID"))					
				m_objTipoKilometrajeID = IIf(IsDBNull(dr("objTipoKilometrajeID")), Nothing, dr("objTipoKilometrajeID"))					
				m_ValorKilometraje = IIf(IsDBNull(dr("ValorKilometraje")), Nothing, dr("ValorKilometraje"))					
				m_ModeloMoto = IIf(IsDBNull(dr("ModeloMoto")), Nothing, dr("ModeloMoto"))					
				m_MarcaMoto = IIf(IsDBNull(dr("MarcaMoto")), Nothing, dr("MarcaMoto"))					
				m_NoMotorMoto = IIf(IsDBNull(dr("NoMotorMoto")), Nothing, dr("NoMotorMoto"))					
				m_ChasisMoto = IIf(IsDBNull(dr("ChasisMoto")), Nothing, dr("ChasisMoto"))					
				m_PlacaMoto = IIf(IsDBNull(dr("PlacaMoto")), Nothing, dr("PlacaMoto"))					
				m_ColorMoto = IIf(IsDBNull(dr("ColorMoto")), Nothing, dr("ColorMoto"))					
				m_ServicioGarantia = IIf(IsDBNull(dr("ServicioGarantia")), Nothing, dr("ServicioGarantia"))					
				m_CantidadServiciosGarantia = IIf(IsDBNull(dr("CantidadServiciosGarantia")), Nothing, dr("CantidadServiciosGarantia"))					
				m_ObservacionesJefeTaller = IIf(IsDBNull(dr("ObservacionesJefeTaller")), Nothing, dr("ObservacionesJefeTaller"))					
				m_FallasReportadasCliente = IIf(IsDBNull(dr("FallasReportadasCliente")), Nothing, dr("FallasReportadasCliente"))					
				m_MotoRecibidaDe = IIf(IsDBNull(dr("MotoRecibidaDe")), Nothing, dr("MotoRecibidaDe"))					
				m_CambioAceite = IIf(IsDBNull(dr("CambioAceite")), Nothing, dr("CambioAceite"))					
				m_LimpiezaCarburador = IIf(IsDBNull(dr("LimpiezaCarburador")), Nothing, dr("LimpiezaCarburador"))					
				m_AjusteFrenos = IIf(IsDBNull(dr("AjusteFrenos")), Nothing, dr("AjusteFrenos"))					
				m_AjusteCadenaSecundaria = IIf(IsDBNull(dr("AjusteCadenaSecundaria")), Nothing, dr("AjusteCadenaSecundaria"))					
				m_ChequeoTiempoEncendido = IIf(IsDBNull(dr("ChequeoTiempoEncendido")), Nothing, dr("ChequeoTiempoEncendido"))					
				m_ChequeoBateria = IIf(IsDBNull(dr("ChequeoBateria")), Nothing, dr("ChequeoBateria"))					
				m_RegulacionEmbrague = IIf(IsDBNull(dr("RegulacionEmbrague")), Nothing, dr("RegulacionEmbrague"))					
				m_CalibrarValvulas = IIf(IsDBNull(dr("CalibrarValvulas")), Nothing, dr("CalibrarValvulas"))					
				m_EngraseEjeSuspensionTrasera = IIf(IsDBNull(dr("EngraseEjeSuspensionTrasera")), Nothing, dr("EngraseEjeSuspensionTrasera"))					
				m_EngraseEjeDelanteroTrasero = IIf(IsDBNull(dr("EngraseEjeDelanteroTrasero")), Nothing, dr("EngraseEjeDelanteroTrasero"))					
				m_CambioFricciones = IIf(IsDBNull(dr("CambioFricciones")), Nothing, dr("CambioFricciones"))					
				m_Otros = IIf(IsDBNull(dr("Otros")), Nothing, dr("Otros"))					
				m_FechaEntrega = IIf(IsDBNull(dr("FechaEntrega")), Nothing, dr("FechaEntrega"))					
				m_DiagnosticoTaller = IIf(IsDBNull(dr("DiagnosticoTaller")), Nothing, dr("DiagnosticoTaller"))					
				m_Solucion = IIf(IsDBNull(dr("Solucion")), Nothing, dr("Solucion"))					
				m_MotoEntregadaA = IIf(IsDBNull(dr("MotoEntregadaA")), Nothing, dr("MotoEntregadaA"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				Return True
			Else
				Return False
			End If			
        Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StaServicioTaller en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StaServicioTaller"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet 
		Try
			If pTransac is nothing Then 
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "StaServicioTaller"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StaServicioTaller en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StaServicioTaller"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

		Dim ds As DataSet 
		Try
			If pTransac Is Nothing then
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "StaServicioTaller"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StaServicioTaller en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StaServicioTaller"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If
		
		Dim dr As SqlDataReader = Nothing
		Try
			If pTransac is nothing then
				dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
			Else
				dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			Return (dr)
		Catch ex As Exception
			Throw        
		Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try	
    End Function
#End Region

#Region " Insert "

	''' <summary>
    ''' 	Inserta en la base de datos una nueva instancia de la clase StaServicioTaller.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StaServicioTaller("
		sCommand &= "objSccCuentaID,"
		sCommand &= "objSccCuentaTiendaID,"
		sCommand &= "objServicioTiendaID,"
		sCommand &= "objClienteID,"
		sCommand &= "objTipoServicioID,"
		sCommand &= "objEstadoServicioID,"
		sCommand &= "objTecnicoAsignadoID,"
		sCommand &= "FechaRecibida,"
		sCommand &= "objNivelCombustibleID,"
		sCommand &= "objTipoKilometrajeID,"
		sCommand &= "ValorKilometraje,"
		sCommand &= "ModeloMoto,"
		sCommand &= "MarcaMoto,"
		sCommand &= "NoMotorMoto,"
		sCommand &= "ChasisMoto,"
		sCommand &= "PlacaMoto,"
		sCommand &= "ColorMoto,"
		sCommand &= "ServicioGarantia,"
		sCommand &= "CantidadServiciosGarantia,"
		sCommand &= "ObservacionesJefeTaller,"
		sCommand &= "FallasReportadasCliente,"
		sCommand &= "MotoRecibidaDe,"
		sCommand &= "CambioAceite,"
		sCommand &= "LimpiezaCarburador,"
		sCommand &= "AjusteFrenos,"
		sCommand &= "AjusteCadenaSecundaria,"
		sCommand &= "ChequeoTiempoEncendido,"
		sCommand &= "ChequeoBateria,"
		sCommand &= "RegulacionEmbrague,"
		sCommand &= "CalibrarValvulas,"
		sCommand &= "EngraseEjeSuspensionTrasera,"
		sCommand &= "EngraseEjeDelanteroTrasero,"
		sCommand &= "CambioFricciones,"
		sCommand &= "Otros,"
		sCommand &= "FechaEntrega,"
		sCommand &= "DiagnosticoTaller,"
		sCommand &= "Solucion,"
		sCommand &= "MotoEntregadaA,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objSccCuentaTiendaID,"
		sCommand &= "@objServicioTiendaID,"
		sCommand &= "@objClienteID,"
		sCommand &= "@objTipoServicioID,"
		sCommand &= "@objEstadoServicioID,"
		sCommand &= "@objTecnicoAsignadoID,"
		sCommand &= "@FechaRecibida,"
		sCommand &= "@objNivelCombustibleID,"
		sCommand &= "@objTipoKilometrajeID,"
		sCommand &= "@ValorKilometraje,"
		sCommand &= "@ModeloMoto,"
		sCommand &= "@MarcaMoto,"
		sCommand &= "@NoMotorMoto,"
		sCommand &= "@ChasisMoto,"
		sCommand &= "@PlacaMoto,"
		sCommand &= "@ColorMoto,"
		sCommand &= "@ServicioGarantia,"
		sCommand &= "@CantidadServiciosGarantia,"
		sCommand &= "@ObservacionesJefeTaller,"
		sCommand &= "@FallasReportadasCliente,"
		sCommand &= "@MotoRecibidaDe,"
		sCommand &= "@CambioAceite,"
		sCommand &= "@LimpiezaCarburador,"
		sCommand &= "@AjusteFrenos,"
		sCommand &= "@AjusteCadenaSecundaria,"
		sCommand &= "@ChequeoTiempoEncendido,"
		sCommand &= "@ChequeoBateria,"
		sCommand &= "@RegulacionEmbrague,"
		sCommand &= "@CalibrarValvulas,"
		sCommand &= "@EngraseEjeSuspensionTrasera,"
		sCommand &= "@EngraseEjeDelanteroTrasero,"
		sCommand &= "@CambioFricciones,"
		sCommand &= "@Otros,"
		sCommand &= "@FechaEntrega,"
		sCommand &= "@DiagnosticoTaller,"
		sCommand &= "@Solucion,"
		sCommand &= "@MotoEntregadaA,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@StaServicioTallerID = StaServicioTallerID from StaServicioTaller where "		
		sCommand &= "StaServicioTallerID = SCOPE_IDENTITY()"
		
		
		Dim arParams(42) As SqlParameter
		arParams(0) = New SqlParameter("@StaServicioTallerID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaTiendaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaTiendaID
        End If
		arParams(3) = New SqlParameter("@objServicioTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objServicioTiendaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objServicioTiendaID
        End If
		arParams(4) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objClienteID
        End If
		arParams(5) = New SqlParameter("@objTipoServicioID", SqlDbType.Int)		
		If IsDBNull(m_objTipoServicioID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoServicioID
        End If
		arParams(6) = New SqlParameter("@objEstadoServicioID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoServicioID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoServicioID
        End If
		arParams(7) = New SqlParameter("@objTecnicoAsignadoID", SqlDbType.Int)		
		If IsDBNull(m_objTecnicoAsignadoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objTecnicoAsignadoID
        End If
		arParams(8) = New SqlParameter("@FechaRecibida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRecibida) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaRecibida
        End If
		arParams(9) = New SqlParameter("@objNivelCombustibleID", SqlDbType.Int)		
		If IsDBNull(m_objNivelCombustibleID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objNivelCombustibleID
        End If
		arParams(10) = New SqlParameter("@objTipoKilometrajeID", SqlDbType.Int)		
		If IsDBNull(m_objTipoKilometrajeID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objTipoKilometrajeID
        End If
		arParams(11) = New SqlParameter("@ValorKilometraje", SqlDbType.Int)		
		If IsDBNull(m_ValorKilometraje) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ValorKilometraje
        End If
		arParams(12) = New SqlParameter("@ModeloMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ModeloMoto) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ModeloMoto
        End If
		arParams(13) = New SqlParameter("@MarcaMoto", SqlDbType.VarChar)		
		If IsDBNull(m_MarcaMoto) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_MarcaMoto
        End If
		arParams(14) = New SqlParameter("@NoMotorMoto", SqlDbType.VarChar)		
		If IsDBNull(m_NoMotorMoto) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_NoMotorMoto
        End If
		arParams(15) = New SqlParameter("@ChasisMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ChasisMoto) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_ChasisMoto
        End If
		arParams(16) = New SqlParameter("@PlacaMoto", SqlDbType.VarChar)		
		If IsDBNull(m_PlacaMoto) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_PlacaMoto
        End If
		arParams(17) = New SqlParameter("@ColorMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ColorMoto) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_ColorMoto
        End If
		arParams(18) = New SqlParameter("@ServicioGarantia", SqlDbType.Bit)		
		If IsDBNull(m_ServicioGarantia) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_ServicioGarantia
        End If
		arParams(19) = New SqlParameter("@CantidadServiciosGarantia", SqlDbType.Int)		
		If IsDBNull(m_CantidadServiciosGarantia) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_CantidadServiciosGarantia
        End If
		arParams(20) = New SqlParameter("@ObservacionesJefeTaller", SqlDbType.VarChar)		
		If IsDBNull(m_ObservacionesJefeTaller) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_ObservacionesJefeTaller
        End If
		arParams(21) = New SqlParameter("@FallasReportadasCliente", SqlDbType.VarChar)		
		If IsDBNull(m_FallasReportadasCliente) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FallasReportadasCliente
        End If
		arParams(22) = New SqlParameter("@MotoRecibidaDe", SqlDbType.VarChar)		
		If IsDBNull(m_MotoRecibidaDe) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_MotoRecibidaDe
        End If
		arParams(23) = New SqlParameter("@CambioAceite", SqlDbType.Bit)		
		If IsDBNull(m_CambioAceite) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_CambioAceite
        End If
		arParams(24) = New SqlParameter("@LimpiezaCarburador", SqlDbType.Bit)		
		If IsDBNull(m_LimpiezaCarburador) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_LimpiezaCarburador
        End If
		arParams(25) = New SqlParameter("@AjusteFrenos", SqlDbType.Bit)		
		If IsDBNull(m_AjusteFrenos) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_AjusteFrenos
        End If
		arParams(26) = New SqlParameter("@AjusteCadenaSecundaria", SqlDbType.Bit)		
		If IsDBNull(m_AjusteCadenaSecundaria) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_AjusteCadenaSecundaria
        End If
		arParams(27) = New SqlParameter("@ChequeoTiempoEncendido", SqlDbType.Bit)		
		If IsDBNull(m_ChequeoTiempoEncendido) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_ChequeoTiempoEncendido
        End If
		arParams(28) = New SqlParameter("@ChequeoBateria", SqlDbType.Bit)		
		If IsDBNull(m_ChequeoBateria) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_ChequeoBateria
        End If
		arParams(29) = New SqlParameter("@RegulacionEmbrague", SqlDbType.Bit)		
		If IsDBNull(m_RegulacionEmbrague) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_RegulacionEmbrague
        End If
		arParams(30) = New SqlParameter("@CalibrarValvulas", SqlDbType.Bit)		
		If IsDBNull(m_CalibrarValvulas) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_CalibrarValvulas
        End If
		arParams(31) = New SqlParameter("@EngraseEjeSuspensionTrasera", SqlDbType.Bit)		
		If IsDBNull(m_EngraseEjeSuspensionTrasera) Then
            arParams(31).Value = DBNull.Value
        Else
            arParams(31).Value = m_EngraseEjeSuspensionTrasera
        End If
		arParams(32) = New SqlParameter("@EngraseEjeDelanteroTrasero", SqlDbType.Bit)		
		If IsDBNull(m_EngraseEjeDelanteroTrasero) Then
            arParams(32).Value = DBNull.Value
        Else
            arParams(32).Value = m_EngraseEjeDelanteroTrasero
        End If
		arParams(33) = New SqlParameter("@CambioFricciones", SqlDbType.Bit)		
		If IsDBNull(m_CambioFricciones) Then
            arParams(33).Value = DBNull.Value
        Else
            arParams(33).Value = m_CambioFricciones
        End If
		arParams(34) = New SqlParameter("@Otros", SqlDbType.VarChar)		
		If IsDBNull(m_Otros) Then
            arParams(34).Value = DBNull.Value
        Else
            arParams(34).Value = m_Otros
        End If
		arParams(35) = New SqlParameter("@FechaEntrega", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEntrega) Then
            arParams(35).Value = DBNull.Value
        Else
            arParams(35).Value = m_FechaEntrega
        End If
		arParams(36) = New SqlParameter("@DiagnosticoTaller", SqlDbType.VarChar)		
		If IsDBNull(m_DiagnosticoTaller) Then
            arParams(36).Value = DBNull.Value
        Else
            arParams(36).Value = m_DiagnosticoTaller
        End If
		arParams(37) = New SqlParameter("@Solucion", SqlDbType.VarChar)		
		If IsDBNull(m_Solucion) Then
            arParams(37).Value = DBNull.Value
        Else
            arParams(37).Value = m_Solucion
        End If
		arParams(38) = New SqlParameter("@MotoEntregadaA", SqlDbType.VarChar)		
		If IsDBNull(m_MotoEntregadaA) Then
            arParams(38).Value = DBNull.Value
        Else
            arParams(38).Value = m_MotoEntregadaA
        End If
		arParams(39) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(39).Value = DBNull.Value
        Else
            arParams(39).Value = m_FechaCreacion
        End If
		arParams(40) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(40).Value = DBNull.Value
        Else
            arParams(40).Value = m_UsuarioCreacion
        End If
		arParams(41) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(41).Value = DBNull.Value
        Else
            arParams(41).Value = m_FechaModificacion
        End If
		arParams(42) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(42).Value = DBNull.Value
        Else
            arParams(42).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_StaServicioTallerID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StaServicioTaller en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StaServicioTaller set "		
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objSccCuentaTiendaID = @objSccCuentaTiendaID,"
		sCommand &= "objServicioTiendaID = @objServicioTiendaID,"
		sCommand &= "objClienteID = @objClienteID,"
		sCommand &= "objTipoServicioID = @objTipoServicioID,"
		sCommand &= "objEstadoServicioID = @objEstadoServicioID,"
		sCommand &= "objTecnicoAsignadoID = @objTecnicoAsignadoID,"
		sCommand &= "FechaRecibida = @FechaRecibida,"
		sCommand &= "objNivelCombustibleID = @objNivelCombustibleID,"
		sCommand &= "objTipoKilometrajeID = @objTipoKilometrajeID,"
		sCommand &= "ValorKilometraje = @ValorKilometraje,"
		sCommand &= "ModeloMoto = @ModeloMoto,"
		sCommand &= "MarcaMoto = @MarcaMoto,"
		sCommand &= "NoMotorMoto = @NoMotorMoto,"
		sCommand &= "ChasisMoto = @ChasisMoto,"
		sCommand &= "PlacaMoto = @PlacaMoto,"
		sCommand &= "ColorMoto = @ColorMoto,"
		sCommand &= "ServicioGarantia = @ServicioGarantia,"
		sCommand &= "CantidadServiciosGarantia = @CantidadServiciosGarantia,"
		sCommand &= "ObservacionesJefeTaller = @ObservacionesJefeTaller,"
		sCommand &= "FallasReportadasCliente = @FallasReportadasCliente,"
		sCommand &= "MotoRecibidaDe = @MotoRecibidaDe,"
		sCommand &= "CambioAceite = @CambioAceite,"
		sCommand &= "LimpiezaCarburador = @LimpiezaCarburador,"
		sCommand &= "AjusteFrenos = @AjusteFrenos,"
		sCommand &= "AjusteCadenaSecundaria = @AjusteCadenaSecundaria,"
		sCommand &= "ChequeoTiempoEncendido = @ChequeoTiempoEncendido,"
		sCommand &= "ChequeoBateria = @ChequeoBateria,"
		sCommand &= "RegulacionEmbrague = @RegulacionEmbrague,"
		sCommand &= "CalibrarValvulas = @CalibrarValvulas,"
		sCommand &= "EngraseEjeSuspensionTrasera = @EngraseEjeSuspensionTrasera,"
		sCommand &= "EngraseEjeDelanteroTrasero = @EngraseEjeDelanteroTrasero,"
		sCommand &= "CambioFricciones = @CambioFricciones,"
		sCommand &= "Otros = @Otros,"
		sCommand &= "FechaEntrega = @FechaEntrega,"
		sCommand &= "DiagnosticoTaller = @DiagnosticoTaller,"
		sCommand &= "Solucion = @Solucion,"
		sCommand &= "MotoEntregadaA = @MotoEntregadaA,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "StaServicioTallerID = @StaServicioTallerID"					
		
		Dim arParams(42) As SqlParameter
		arParams(0) = New SqlParameter("@StaServicioTallerID", SqlDbType.Int)		
		If IsDBNull(m_StaServicioTallerID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StaServicioTallerID
        End If
		arParams(1) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaTiendaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaTiendaID
        End If
		arParams(3) = New SqlParameter("@objServicioTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objServicioTiendaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objServicioTiendaID
        End If
		arParams(4) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objClienteID
        End If
		arParams(5) = New SqlParameter("@objTipoServicioID", SqlDbType.Int)		
		If IsDBNull(m_objTipoServicioID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoServicioID
        End If
		arParams(6) = New SqlParameter("@objEstadoServicioID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoServicioID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoServicioID
        End If
		arParams(7) = New SqlParameter("@objTecnicoAsignadoID", SqlDbType.Int)		
		If IsDBNull(m_objTecnicoAsignadoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objTecnicoAsignadoID
        End If
		arParams(8) = New SqlParameter("@FechaRecibida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRecibida) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaRecibida
        End If
		arParams(9) = New SqlParameter("@objNivelCombustibleID", SqlDbType.Int)		
		If IsDBNull(m_objNivelCombustibleID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objNivelCombustibleID
        End If
		arParams(10) = New SqlParameter("@objTipoKilometrajeID", SqlDbType.Int)		
		If IsDBNull(m_objTipoKilometrajeID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objTipoKilometrajeID
        End If
		arParams(11) = New SqlParameter("@ValorKilometraje", SqlDbType.Int)		
		If IsDBNull(m_ValorKilometraje) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ValorKilometraje
        End If
		arParams(12) = New SqlParameter("@ModeloMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ModeloMoto) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ModeloMoto
        End If
		arParams(13) = New SqlParameter("@MarcaMoto", SqlDbType.VarChar)		
		If IsDBNull(m_MarcaMoto) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_MarcaMoto
        End If
		arParams(14) = New SqlParameter("@NoMotorMoto", SqlDbType.VarChar)		
		If IsDBNull(m_NoMotorMoto) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_NoMotorMoto
        End If
		arParams(15) = New SqlParameter("@ChasisMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ChasisMoto) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_ChasisMoto
        End If
		arParams(16) = New SqlParameter("@PlacaMoto", SqlDbType.VarChar)		
		If IsDBNull(m_PlacaMoto) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_PlacaMoto
        End If
		arParams(17) = New SqlParameter("@ColorMoto", SqlDbType.VarChar)		
		If IsDBNull(m_ColorMoto) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_ColorMoto
        End If
		arParams(18) = New SqlParameter("@ServicioGarantia", SqlDbType.Bit)		
		If IsDBNull(m_ServicioGarantia) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_ServicioGarantia
        End If
		arParams(19) = New SqlParameter("@CantidadServiciosGarantia", SqlDbType.Int)		
		If IsDBNull(m_CantidadServiciosGarantia) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_CantidadServiciosGarantia
        End If
		arParams(20) = New SqlParameter("@ObservacionesJefeTaller", SqlDbType.VarChar)		
		If IsDBNull(m_ObservacionesJefeTaller) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_ObservacionesJefeTaller
        End If
		arParams(21) = New SqlParameter("@FallasReportadasCliente", SqlDbType.VarChar)		
		If IsDBNull(m_FallasReportadasCliente) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FallasReportadasCliente
        End If
		arParams(22) = New SqlParameter("@MotoRecibidaDe", SqlDbType.VarChar)		
		If IsDBNull(m_MotoRecibidaDe) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_MotoRecibidaDe
        End If
		arParams(23) = New SqlParameter("@CambioAceite", SqlDbType.Bit)		
		If IsDBNull(m_CambioAceite) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_CambioAceite
        End If
		arParams(24) = New SqlParameter("@LimpiezaCarburador", SqlDbType.Bit)		
		If IsDBNull(m_LimpiezaCarburador) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_LimpiezaCarburador
        End If
		arParams(25) = New SqlParameter("@AjusteFrenos", SqlDbType.Bit)		
		If IsDBNull(m_AjusteFrenos) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_AjusteFrenos
        End If
		arParams(26) = New SqlParameter("@AjusteCadenaSecundaria", SqlDbType.Bit)		
		If IsDBNull(m_AjusteCadenaSecundaria) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_AjusteCadenaSecundaria
        End If
		arParams(27) = New SqlParameter("@ChequeoTiempoEncendido", SqlDbType.Bit)		
		If IsDBNull(m_ChequeoTiempoEncendido) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_ChequeoTiempoEncendido
        End If
		arParams(28) = New SqlParameter("@ChequeoBateria", SqlDbType.Bit)		
		If IsDBNull(m_ChequeoBateria) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_ChequeoBateria
        End If
		arParams(29) = New SqlParameter("@RegulacionEmbrague", SqlDbType.Bit)		
		If IsDBNull(m_RegulacionEmbrague) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_RegulacionEmbrague
        End If
		arParams(30) = New SqlParameter("@CalibrarValvulas", SqlDbType.Bit)		
		If IsDBNull(m_CalibrarValvulas) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_CalibrarValvulas
        End If
		arParams(31) = New SqlParameter("@EngraseEjeSuspensionTrasera", SqlDbType.Bit)		
		If IsDBNull(m_EngraseEjeSuspensionTrasera) Then
            arParams(31).Value = DBNull.Value
        Else
            arParams(31).Value = m_EngraseEjeSuspensionTrasera
        End If
		arParams(32) = New SqlParameter("@EngraseEjeDelanteroTrasero", SqlDbType.Bit)		
		If IsDBNull(m_EngraseEjeDelanteroTrasero) Then
            arParams(32).Value = DBNull.Value
        Else
            arParams(32).Value = m_EngraseEjeDelanteroTrasero
        End If
		arParams(33) = New SqlParameter("@CambioFricciones", SqlDbType.Bit)		
		If IsDBNull(m_CambioFricciones) Then
            arParams(33).Value = DBNull.Value
        Else
            arParams(33).Value = m_CambioFricciones
        End If
		arParams(34) = New SqlParameter("@Otros", SqlDbType.VarChar)		
		If IsDBNull(m_Otros) Then
            arParams(34).Value = DBNull.Value
        Else
            arParams(34).Value = m_Otros
        End If
		arParams(35) = New SqlParameter("@FechaEntrega", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEntrega) Then
            arParams(35).Value = DBNull.Value
        Else
            arParams(35).Value = m_FechaEntrega
        End If
		arParams(36) = New SqlParameter("@DiagnosticoTaller", SqlDbType.VarChar)		
		If IsDBNull(m_DiagnosticoTaller) Then
            arParams(36).Value = DBNull.Value
        Else
            arParams(36).Value = m_DiagnosticoTaller
        End If
		arParams(37) = New SqlParameter("@Solucion", SqlDbType.VarChar)		
		If IsDBNull(m_Solucion) Then
            arParams(37).Value = DBNull.Value
        Else
            arParams(37).Value = m_Solucion
        End If
		arParams(38) = New SqlParameter("@MotoEntregadaA", SqlDbType.VarChar)		
		If IsDBNull(m_MotoEntregadaA) Then
            arParams(38).Value = DBNull.Value
        Else
            arParams(38).Value = m_MotoEntregadaA
        End If
		arParams(39) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(39).Value = DBNull.Value
        Else
            arParams(39).Value = m_FechaCreacion
        End If
		arParams(40) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(40).Value = DBNull.Value
        Else
            arParams(40).Value = m_UsuarioCreacion
        End If
		arParams(41) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(41).Value = DBNull.Value
        Else
            arParams(41).Value = m_FechaModificacion
        End If
		arParams(42) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(42).Value = DBNull.Value
        Else
            arParams(42).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
        Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region
	
#Region " Delete "

	''' <summary>
    ''' Borra un objeto StaServicioTaller de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StaServicioTaller where " & " StaServicioTallerID = " & m_StaServicioTallerID
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub

    ''' <summary>
    ''' Borra un objeto StaServicioTaller de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StaServicioTallerID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StaServicioTaller where " & " StaServicioTallerID = " & p_StaServicioTallerID
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub	

    ''' <summary>
    ''' Borra objetos StaServicioTaller de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StaServicioTaller where " & pWhere
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region

End Class
