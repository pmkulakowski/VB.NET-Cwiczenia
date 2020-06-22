Public NotInheritable Class Zwierze
    Inherits Towar
    Private strGatunek As String

    Property Gatunek() As String
        Get
            Return strGatunek
        End Get
        Set(ByVal value As String)
            strGatunek = value
        End Set
    End Property

    Sub New()
        Me.Nazwa = "Pimpuś"
        Me.Cena = 2345.99
        Me.Gatunek = "Koń"
    End Sub

    Public Overloads Overrides Function WyliczVAT() As Double
        Return MyBase.WyliczVAT * 5
    End Function

    Public Shared Shadows Sub Dzis(ByVal parameter As Object)
        MsgBox("Ukryliśmy metodę klasy bazowej")
    End Sub

End Class
