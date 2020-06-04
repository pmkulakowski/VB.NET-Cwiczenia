Public Class frmStart

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub cmdUkryj_Click(sender As System.Object, e As System.EventArgs) Handles cmdUkryj.Click
        lblKursor.Visible = Not lblKursor.Visible
    End Sub

    Private Sub frmStart_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        lblKursor.Text = "X: " & e.X.ToString & " Y: " & e.Y.ToString
    End Sub

    Private Sub cmdWyswietl_Click(sender As System.Object, e As System.EventArgs) Handles cmdWyswietl.Click
        Dim formularz As New frmDrugi
        formularz.Text = txtEtykieta.Text
        formularz.ShowDialog()

    End Sub
End Class
