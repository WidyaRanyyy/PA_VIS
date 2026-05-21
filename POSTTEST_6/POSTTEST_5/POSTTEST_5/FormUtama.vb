Public Class FormUtama

    Private Sub DataKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKamarToolStripMenuItem.Click
        FormKamar.ShowDialog()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        FormCheckIn.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChechkOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChechkOutToolStripMenuItem.Click
        FormCheckOut.ShowDialog()
    End Sub

    Private Sub PanelBackground_Paint(sender As Object, e As PaintEventArgs) Handles PanelBackground.Paint

    End Sub
End Class