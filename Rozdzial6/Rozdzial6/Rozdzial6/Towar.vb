Public Class Towar

    Private dblCena As Double
    Private strNazwa As String
    Private dblPodatek As Double

    Private Const VAT As Double = 0.22
    Private Const DOMIAR As Double = 0.55

    Private Shared Magazynier As String = "Szeryf"

    Public Overridable Overloads Function WyliczVAT() As Double
        Return Me.dblCena * VAT
    End Function

    Public Overloads Function WyliczVAT(ByVal dblKwota As Double) As Double
        Return dblKwota * VAT
    End Function

    Public Property Nazwa() As String
        Get
            If strNazwa Like "_#*" Then
                Return ""
            Else
                Return strNazwa
            End If
        End Get
        Set(ByVal value As String)
            If value Like "_#*" Then
                MsgBox("Nieprawidłowa nazwa towaru", MsgBoxStyle.Critical, "Błąd!")
            Else
                strNazwa = Trim(value)
            End If
        End Set
    End Property

    Public ReadOnly Property Podatek() As Double
        Get
            dblPodatek = dblCena * DOMIAR
            Return dblPodatek
        End Get
    End Property

    Public WriteOnly Property Cena() As Double
        Set(ByVal value As Double)
            dblCena = value
        End Set
    End Property

    Sub New()
        Me.Nazwa = "17. letni Ardbeg"
        Me.Cena = 200
    End Sub

    Sub New(ByVal Nazwa As String, ByVal Cena As Double)
        Me.Nazwa = Nazwa
        Me.Cena = Cena
    End Sub

    Protected Overloads Sub Finalize()
        MsgBox("Zwalniam zasoby po instancjach klasy Towar", MsgBoxStyle.Information, "Kolekcjoner śmieci")
    End Sub

    Public Property OsobaOdpowiedzialna() As String
        Get
            Return Magazynier
        End Get
        Set(ByVal value As String)
            Magazynier = value
        End Set
    End Property

    Public Shared Function Dzisiaj() As Date
        Return Today
    End Function
End Class
