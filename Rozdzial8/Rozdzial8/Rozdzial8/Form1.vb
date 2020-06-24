Public Class frmSprDane

    Dim strNazwaFirmy As String


    Private Sub calData_DateChanged(sender As Object, e As System.Windows.Forms.DateRangeEventArgs)
        If e.Start <> e.End Then
            lblData.Text = "Data początkowa: " + e.Start.Month.ToString + " " + e.Start.Day.ToString + _
                vbCrLf + "Data końckowa: " + e.End.Month.ToString + " " + e.End.Day.ToString
        Else
            lblData.Text = "Wybrano datę: " + e.Start.ToString
        End If
    End Sub

    Private Sub dtpData_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpData.ValueChanged
        lblData.Text = "Wybrano datę: " + dtpData.Value.DayOfWeek.ToString + " " + dtpData.Value
    End Sub

    Private Sub trbLiczba_Scroll(sender As Object, e As System.EventArgs) Handles trbLiczba.Scroll
        lblLiczba.Text = trbLiczba.Value.ToString
    End Sub

    Private Sub Kolory_CheckedChanged(sender As Object, e As System.EventArgs) Handles optBialy.CheckedChanged, optCzarny.CheckedChanged, optCzerwony.CheckedChanged
        If optBialy.Checked Then
            lblWybor.Text = "Kolor biały"
        ElseIf optCzarny.Checked Then
            lblWybor.Text = "Kolor czerwony"
        Else
            lblWybor.Text = "kolor czarny"
        End If
    End Sub

    Private Sub cmdOtworz_Click(sender As System.Object, e As System.EventArgs) Handles cmdOtworz.Click
        Dim dialog As New OpenFileDialog
        dialog.ShowDialog()
    End Sub

    Private Sub cmdKolor_Click(sender As System.Object, e As System.EventArgs) Handles cmdKolor.Click
        Dim dialog As New ColorDialog
        If dialog.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = dialog.Color
        End If
    End Sub

    Private Sub frmSprDane_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtHaslo.MaxLength = 8
        txtHaslo.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtHaslo_Leave(sender As Object, e As System.EventArgs) Handles txtHaslo.Leave
        lblHaslo.Text = txtHaslo.Text
    End Sub

    Private Sub medTelefon_Leave(sender As Object, e As System.EventArgs) Handles medTelefon.Leave
        lblTelefon.Text = medTelefon.Text
        lblHaslo.Text = medTelefon.SelectedText
    End Sub


    Private Sub txtLiczba_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLiczba.Validating
        If IsNumeric(txtLiczba.Text) Then
            'MsgBox("Dane poprawne")
            errSprDane.SetError(txtLiczba, "")
        Else
            'MsgBox("Podana wartość nie jest liczbą!")
            errSprDane.SetError(txtLiczba, "Podana wartość nie jest liczbą!")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtData_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtData.Validating
        If IsDate(txtData.Text) Then
            'MsgBox("Dane prawidłowe")
            errSprDane.SetError(txtData, "")
        Else
            'MsgBox("Podana wartość nie jest datą!")
            errSprDane.SetError(txtData, "Podana wartość nie jest datą!")
            txtData.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdPomoc_Click(sender As System.Object, e As System.EventArgs) Handles cmdPomoc.Click
        MsgBox("Klikniecie nie wywołało zdarzeń sprawdzania poprawności danych.")
    End Sub

    Private Sub txtNazwaFirmy_LostFocus(sender As Object, e As System.EventArgs) Handles txtNazwaFirmy.LostFocus
        strNazwaFirmy = Trim(txtNazwaFirmy.Text)
        lblData.Text = strNazwaFirmy + " nazwa liczy " + Len(strNazwaFirmy).ToString + " znaków"
    End Sub

    Private Sub cmdSprawdz_Click(sender As Object, e As System.EventArgs) Handles cmdSprawdz.Click

        errSprDane.SetError(dtpData, "")
        errSprDane.SetError(trbLiczba, "")
        errSprDane.SetError(txtNazwaFirmy, "")

        If Trim(lblData.Text) = "" Then
            errSprDane.SetError(dtpData, "Wybierz datę!")
            dtpData.Focus()
        ElseIf lblLiczba.Text = "" Then
            errSprDane.SetError(trbLiczba, "Wybierz liczbę")
            trbLiczba.Focus()
        ElseIf (lblLiczba.Text Mod 2) Then
            errSprDane.SetError(trbLiczba, "Wybierz liczbę parzystą")
        ElseIf Microsoft.VisualBasic.Left(strNazwaFirmy, 2) <> "FM" Then
            errSprDane.SetError(txtNazwaFirmy, "Nazwa firmy nie zaczyna się od FM")
            txtNazwaFirmy.Focus()
        Else
            cmdOk.Enabled = True
        End If
    End Sub

    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        MsgBox("Dane zostały sprawdzone")
    End Sub
End Class
