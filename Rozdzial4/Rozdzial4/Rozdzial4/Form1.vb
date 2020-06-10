Public Class frmProcedury

    Dim intParametr As Integer
    Dim strImie As String
    Dim dblKm As Double

    Function PrzeliczKmMile(ByVal dystans As Double) As Double
        Return dystans * 0.6214
    End Function

    Private Sub frmProcedury_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim Sprawdz As Microsoft.VisualBasic.MsgBoxResult
        Sprawdz = MsgBox("Zakończyć działąnie programu?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Uwaga")
        If Sprawdz = MsgBoxResult.No Then e.Cancel = True

    End Sub

    Private Sub frmProcedury_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KolorTla()
        strImie = InputBox("Podaj swoje imię: ", "Witaj", "Anonim")
        Me.Text = strImie + " : Dzisiaj " + Me.Text
    End Sub

    Sub KolorTla()
        Me.BackColor = Color.DarkGray
        Me.Opacity = 0.95
    End Sub

    Sub Potega(ByVal intLiczba As Integer)
        intLiczba *= intLiczba
        lblWartoscKoncowa.Text = intLiczba
    End Sub

    Private Sub cmdStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        intParametr = txtParametr.Text
        Call Potega(intParametr)
        lblWartoscPoczatkowa.Text = intParametr
    End Sub

    Sub ZmienWielkosc(ByVal szerokosc As Integer, Optional ByVal wysokosc As Integer = 400)
        Me.Width = szerokosc
        Me.Height = wysokosc
        lblWysokosc.Text = wysokosc
    End Sub

    Private Sub cmdZmiana_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdZmiana.Click
        Dim intSzerokosc As Integer
        Dim intWysokosc As Integer
        intSzerokosc = CInt(txtParametr.Text)

        If lblWysokosc.Text <> "" Then
            intWysokosc = CInt(lblWysokosc.Text)
            Call ZmienWielkosc(intSzerokosc, intWysokosc)
        Else
            Call ZmienWielkosc(intSzerokosc)
        End If
    End Sub

    Private Sub cmdKonwersja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdKonwersja.Click
        dblKm = CDbl(txtParametr.Text)
        lblMile.Text = PrzeliczKmMile(dblKm)
    End Sub
End Class
