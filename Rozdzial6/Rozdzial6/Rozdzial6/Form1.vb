Public Class frmKlasy

    Dim Towar1 As New Towar
    Dim Towar2 As New Towar("pianino", 555.12)
    Dim Zwierze1 As New Zwierze

    Private Sub txtT1Nazwa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtT1Nazwa.Leave
        MsgBox("Poprzednio nazwą towaru był: " + Towar1.Nazwa, MsgBoxStyle.Information, "Komunikat")
        Towar1.Nazwa = txtT1Nazwa.Text
        MsgBox("Nową nazwą towaru jest: " + Towar1.Nazwa, MsgBoxStyle.Information, "Komunikat")
    End Sub

    Private Sub txtT2Nazwa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtT2Nazwa.Leave
        MsgBox("Poprzednio nazwą towaru był: " + Towar2.Nazwa, MsgBoxStyle.Information, "Komunikat")
        Towar2.Nazwa = txtT2Nazwa.Text
        MsgBox("Nową nazwą towaru jest: " + Towar2.Nazwa, MsgBoxStyle.Information, "Komunikat")
    End Sub

    Private Sub txtT1Cena_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtT1Cena.Leave
        Towar1.Cena = CDbl(txtT1Cena.Text)
        lblT1Podatek.Text = Towar1.Podatek
    End Sub

    Private Sub txtT2Cena_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtT2Cena.Leave
        Towar2.Cena = CDbl(txtT2Cena.Text)
        lblT2Podatek.Text = Towar2.Podatek
    End Sub

    Private Sub cmdT1Vat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdT1Vat.Click
        Dim dblVat As Double

        If Towar1.Nazwa <> "" Then
            dblVat = Towar1.WyliczVAT()
        Else
            dblVat = Towar1.WyliczVAT(CDbl(InputBox("Podaj kwotę: ")))
        End If
        MsgBox("Wartość podatku VAT wynosi: " + dblVat.ToString, MsgBoxStyle.Information, "Komunikat")
    End Sub

    Private Sub cmdT2Vat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdT2Vat.Click
        Dim dblVat As Double

        If Towar2.Nazwa <> "" Then
            dblVat = Towar2.WyliczVAT()
        Else
            dblVat = Towar2.WyliczVAT(CDbl(InputBox("Podaj kwotę: ")))
        End If
        MsgBox("Wartość podatku VAT wynosi: " + dblVat.ToString, MsgBoxStyle.Information, "Komunikat")
    End Sub

    Private Sub frmKlasy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtT1Nazwa.Text = Towar1.Nazwa
        txtT2Nazwa.Text = Towar2.Nazwa

        frmT1.Text = frmT1.Text + " odpowiada: " + Towar1.OsobaOdpowiedzialna
        frmT2.Text = frmT2.Text + " odpowiada: " + Towar2.OsobaOdpowiedzialna

        Me.Text = Me.Text + " - dziś jest : " + Towar.Dzisiaj

        txtZGatunek.Text = Zwierze1.Gatunek
        txtZNazwa.Text = Zwierze1.Nazwa
        lblZPodatek.Text = Zwierze1.Podatek
        frmZ.Text = frmZ.Text + " odpowiada: " + Towar2.OsobaOdpowiedzialna

        'MsgBox(Zwierze.Dzisiaj())
        Zwierze.Dzisiaj(Towar1)
    End Sub

    Private Sub frmKlasy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Towar1 = Nothing
        Towar2 = Nothing
    End Sub

    Private Sub cmdZVat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZVat.Click
        Dim dblZVat As Double
        If Zwierze1.Nazwa <> "" Then
            dblZVat = Zwierze1.WyliczVAT()
        Else
            dblZVat = Zwierze1.WyliczVAT(CDbl(InputBox("Podaj kwotę:", "Komunikat")))
        End If
        MsgBox("Wartość podatku VAT wynosi: " + dblZVat.ToString)
    End Sub

    Private Sub txtZNazwa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtZNazwa.Leave
        MsgBox("Poprzednio nazwą zwierzęcia był: " + Zwierze1.Nazwa, MsgBoxStyle.Information, "Komunikat")
        Zwierze1.Nazwa = txtZNazwa.Text
        MsgBox("Nową nazwą zwierzęcia jest: " + Zwierze1.Nazwa, MsgBoxStyle.Information, "Komunikat")
    End Sub
End Class
