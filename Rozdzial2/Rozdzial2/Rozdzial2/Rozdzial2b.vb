Public Class frmZdarzenia

    'Private Sub frmZdarzenia_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    '    lblZdarzenia.Text = "Aktywacja formularza"
    'End Sub

    Private Sub frmZdarzenia_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        lblZdarzenia.Text = "Kliknięcie formularza"
    End Sub

    Private Sub frmZdarzenia_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        lblZdarzenia.Text = "Zmiana rozmiaru formularza"
    End Sub

    Private Sub frmZdarzenia_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        lblZdarzenia.Text = "Aktywowanie obiektu formularza"
    End Sub

    Private Sub Rozdzial2b_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = 500
        Me.Height = 300
        Me.StartPosition = FormStartPosition.CenterScreen
        With lblZdarzenia
            .Width = 500
            .Height = 300
            .Top = 20
            .Left = 20
            .BorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        End With
    End Sub

    Private Sub txtTekst_GotFocus(sender As Object, e As System.EventArgs) Handles txtTekst.GotFocus
        lblZdarzenia.Text = "Zaszło zdarzenie wyboru pola tekstowego"
    End Sub

    Private Sub txtTekst_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTekst.KeyPress
        MsgBox("po wybraniu pola tekstowego naciśnięto klawisz: " + e.KeyChar)
    End Sub

    Private Sub txtTekst_LostFocus(sender As Object, e As System.EventArgs) Handles txtTekst.LostFocus
        lblZdarzenia.Text = "Pole ktestowe przestało być obiektem aktywnym"
    End Sub

    Private Sub txtTekst_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTekst.TextChanged
        lblZdarzenia.Text = "Zaszło zdarzenie zmiany tekstu w polu tekstowym"
    End Sub

    Private Sub cmbPrzycisk_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles cmbPrzycisk.MouseDown
        lblZdarzenia.Text = "Przycisk polecenia został naciśnięty " + e.Button.ToString + " klawisz myszy"
    End Sub

    Private Sub chkWybor_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkWybor.CheckedChanged
        If chkWybor.Checked Then
            lblZdarzenia.Text = "Zaznaczono pole wyboru"
        Else
            lblZdarzenia.Text = "Odznaczono pole wyboru"
        End If
    End Sub

    Private Sub frmZdarzenia_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTekst.MouseMove, _
        lblZdarzenia.MouseMove, MyBase.MouseUp
        lblZdarzenia.Text = "Zdarzenie zgłosił " + sender.GetType.ToString _
            + " Pozycja X: " + e.X.ToString + " Y: " + e.Y.ToString
    End Sub
End Class