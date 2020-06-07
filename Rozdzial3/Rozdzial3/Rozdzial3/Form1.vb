Public Class frmZmienne

    Dim intArgument1, intArgument2 As Integer
    Dim strAgrument1, strArgument2 As String
    Dim decWynik As Decimal = 0.0000001
    Const VAT As Single = 0.22
    Const GODZINY As Short = 60
    Dim blnTest As Boolean
    Dim strImie As String

    Private Structure Osoba
        Dim Imie As String
        Dim DataUr As Date
        Dim Pensja As Double
    End Structure

    Private Sub txtPierwszaLiczba_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPierwszaLiczba.KeyPress, txtDrugaLiczba.KeyPress
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPierwszaLiczba_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPierwszaLiczba.TextChanged
        intArgument1 = CInt(txtPierwszaLiczba.Text)
    End Sub


    Private Sub txtDrugaLiczba_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrugaLiczba.TextChanged
        intArgument2 = CInt(txtDrugaLiczba.Text)
    End Sub

    Private Sub cmdPomnoz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPomnoz.Click
        decWynik = intArgument1 * intArgument2
        lblWynik.Text = decWynik
    End Sub

    Private Sub frmZmienne_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblWynik.Text = decWynik
    End Sub

    Private Sub cmdVat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVat.Click
        decWynik = intArgument1 * VAT
        lblWynik.Text = decWynik
    End Sub

    Private Sub cmdGodziny_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGodziny.Click
        decWynik = intArgument2 / GODZINY
        lblWynik.Text = decWynik
    End Sub

    Private Sub cmdRozne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRozne.Click
        blnTest = intArgument1 <> intArgument2
        lblWynik.Text = blnTest
    End Sub

    Private Sub cmdWieksza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdWieksza.Click
        blnTest = intArgument1 > intArgument2
        lblWynik.Text = blnTest
    End Sub

    Private Sub cmdModulo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModulo.Click
        decWynik = intArgument1 Mod intArgument2
        lblWynik.Text = decWynik
    End Sub

    Private Sub cmdAnd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnd.Click
        blnTest = intArgument1 Mod 2 = 0 And intArgument2 Mod 2 = 0
        lblWynik.Text = blnTest
    End Sub

    Private Sub cmdOrElse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOrElse.Click
        blnTest = intArgument1 > intArgument2 OrElse intArgument1 * 2 > intArgument2 * 3
        lblWynik.Text = blnTest
    End Sub

    Private Sub txtImie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImie.TextChanged
        strImie = txtImie.Text
        lblWynik.Text = strImie
    End Sub

    Private Sub cmdSS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSS.Click
        strAgrument1 = txtPierwszaLiczba.Text
        strArgument2 = txtDrugaLiczba.Text
        lblWynik.Text = strAgrument1 + strArgument2
    End Sub

    Private Sub cmdSI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSI.Click
        strAgrument1 = txtPierwszaLiczba.Text
        lblWynik.Text = strAgrument1 + intArgument2
    End Sub

    Private Sub cmdLicznik_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLicznik.Click
        Static intLicznik As Integer
        intLicznik += 1

        If intLicznik > 0 Then
            Dim intParzyste As Integer
            intParzyste = intLicznik Mod 2
            lblWynik.Text = intParzyste
        End If
        lblWynik.Text = intLicznik
    End Sub

    Private Sub cmdStruktura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStruktura.Click
        Dim Szef As Osoba

        With Szef
            .Imie = txtImie.Text
            .DataUr = #2/12/1979#
            .Pensja = 6666.98
        End With

        Dim NajlepszyPracownik As Osoba

        With NajlepszyPracownik
            .Imie = txtImie.Text + "a"
            .DataUr = #5/25/1985#
            .Pensja = 666.08
        End With

        lblWynik.Text = Szef.Imie + " " + Szef.Pensja.ToString

        MsgBox(NajlepszyPracownik.Imie + " " + NajlepszyPracownik.Pensja.ToString)
    End Sub

    Private Sub CmdTablica1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdTablica1.Click
        Dim Osoby(4) As String
        Osoby(0) = "Ala"
        Osoby(1) = "Basia"
        Osoby(2) = "Kasia"
        Osoby(3) = "Marysia"
        Osoby(4) = "Zosia"
        lblWynik.Text = Osoby(3)

    End Sub

    Private Sub cmdTablica2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTablica2.Click
        Dim Liczby(4, 9) As Integer
        Liczby(0, 0) = 2
        Liczby(0, 7) = 4
        Liczby(1, 2) = 8
        Liczby(1, 9) = 16
        Liczby(4, 9) = 32
        lblWynik.Text = Liczby(1, 2)

        ReDim Preserve Liczby(4, 14)
        Liczby(4, 14) = 64
        lblWynik.Text = Liczby(4, 14)
    End Sub
End Class
