Public Class frmInstrukcjeWarunkowe
    Dim intX As Integer
    Dim intY As Integer
    Dim intIloczyn As Integer

    Dim bytPoziom As Byte
    Dim bytKara As Byte

    Private Sub cmdTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        Static intPunkty As Integer
        Dim intWynik As Integer

        Select Case bytPoziom
            Case 1
                bytKara = 1
            Case 2
                bytKara = 3
            Case 3
                bytKara = 5
            Case 4
                bytKara = 8
            Case Else
                MsgBox("Wybierz poziom trudności", , "Błąd")
                Exit Sub
        End Select

        If bytPoziom <> 1 Then
            lblTabliczbaMnozenia.Visible = False
        Else
            lblTabliczbaMnozenia.Visible = True
        End If

        Randomize()
        intX = CInt(Int(10 * Rnd() + 1))
        intY = CInt(Int(10 * Rnd() + 1))
        intIloczyn = intX * intY

        intWynik = CInt(InputBox("Podaj iloczyn liczb " + intX.ToString + _
                                 " oraz " + intY.ToString, "Test"))

        If intIloczyn = intWynik Then
            intPunkty += 1
            MsgBox("Odpowiedź prawidłowa. Zdobyłeś już " + intPunkty.ToString + _
                   " punktów.", , "Gratulacje!")
        Else
            intPunkty -= bytKara
            MsgBox("Odpowiedź nieprawidłowa. Pozostało Ci " + intPunkty.ToString + _
                   " punktów.", , "Źle!")
        End If


    End Sub

    Private Sub optPoziom1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPoziom1.Click
        bytPoziom = 1
    End Sub

    Private Sub optPoziom2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPoziom2.Click
        bytPoziom = 2
    End Sub

    Private Sub optPoziom3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPoziom3.Click
        bytPoziom = 3
    End Sub

    Private Sub optPoziom4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPoziom4.Click
        bytPoziom = 4
    End Sub

    Private Sub frmInstrukcjeWarunkowe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim wartosc(10, 10) As Byte
        Dim pozX As Byte
        Dim pozY As Byte
        Dim strHaslo As String

        Do
            strHaslo = InputBox("Podaj hasło", "Autoryzacja")
        Loop Until strHaslo = "Tajne"

        For pozY = 1 To 10 Step 1
            For pozX = 1 To 10 Step 1
                wartosc(pozX, pozY) = pozX * pozY
                If wartosc(pozX, pozY) < 10 Then
                    lblTabliczbaMnozenia.Text = lblTabliczbaMnozenia.Text + wartosc(pozX, pozY).ToString + "   "
                Else
                    lblTabliczbaMnozenia.Text = lblTabliczbaMnozenia.Text + wartosc(pozX, pozY).ToString + " "
                End If

            Next
            lblTabliczbaMnozenia.Text = lblTabliczbaMnozenia.Text + vbCrLf
        Next
    End Sub

    Private Sub cmdKoniec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdKoniec.Click
        Dim obj As Object

        For Each obj In Me.Controls
            MsgBox("Kontrolka " + obj.name + " to " + obj.GetType.ToString, , "Komunikat")
        Next
        Application.Exit()
    End Sub


    Private Sub lstUzytkownicy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUzytkownicy.SelectedIndexChanged
        lblUzytkownik.Text = "Użytkownik: " + lstUzytkownicy.SelectedItem
    End Sub

    Private Sub cmdUsun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsun.Click
        lstUzytkownicy.Items.Remove(lstUzytkownicy.SelectedItem)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strImie As String
        strImie = InputBox("Dodaj użytkownika ", "Dodaj Użytkownia")
        lstUzytkownicy.Items.Add(strImie)
    End Sub

End Class
