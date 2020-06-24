Public Class frmBledy


    Private Sub cmdSilnia_Click(sender As Object, e As System.EventArgs) Handles cmdSilnia.Click
        Dim intLiczba As Integer

        intLiczba = InputBox("Podaj liczbę, której silnia ma zostać wyliczona", , 1)

        Try
            MsgBox("Wynik: " + SilniaRekurencja(intLiczba).ToString)
        Catch ex As Exception
            MsgBox("Wystąpił błąd: " + ex.Message + vbCrLf + "Wywołany przez: " + ex.StackTrace)
        Finally
            Static licznikWywolan As Integer
            licznikWywolan += 1
            MsgBox("Licznik wywolan: " + licznikWywolan.ToString)
        End Try

        'Debug.Assert(intLiczba > 1)
        MsgBox("Wynik: " + SilniaIteracja(intLiczba).ToString)


    End Sub

    Function SilniaIteracja(ByVal liczba As Integer) As Double

        Dim decWynik As Decimal = 1
        Dim licznik As Integer

        For licznik = 1 To liczba
            decWynik *= licznik
        Next
        Return decWynik
    End Function

    Function SilniaRekurencja(ByVal liczba As Integer) As Double

        Dim dblWynik As Double = 1
        If liczba < 0 Then
            Throw New ArgumentOutOfRangeException("Ujemny argument")
        Else
            dblWynik = liczba * SilniaRekurencja(liczba - 1)
        End If
        Return dblWynik

    End Function

    Private Sub cmdOtworz_Click(sender As System.Object, e As System.EventArgs) Handles cmdOtworz.Click
        Try
            Dim fs As New System.IO.FileStream("G:\plik.txt", IO.FileMode.Open)
        Catch ex As System.IO.FileNotFoundException
            MsgBox("Nie znaleziono określonego pliku")
        Catch ex As System.IO.DirectoryNotFoundException
            MsgBox("Nieprawidłowa lokalizacja pliku")
        Catch ex As System.UnauthorizedAccessException
            MsgBox("Odmowa dostępu")
        Catch ex As System.IO.FileLoadException
            MsgBox("Uszkodzony plik z danymi")
        Catch ex As Exception
            MsgBox("Nieoczekiwany błąd " + ex.Message)
        End Try
    End Sub
End Class
