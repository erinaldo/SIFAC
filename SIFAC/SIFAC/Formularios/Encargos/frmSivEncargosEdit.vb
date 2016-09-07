Public Class frmSivEncargosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intEncargoID As Integer
    Public boolEditado As Boolean
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property EncargoID() As Integer
        Get
            Return intEncargoID
        End Get
        Set(ByVal value As Integer)
            intEncargoID = value
        End Set
    End Property

#End Region

End Class