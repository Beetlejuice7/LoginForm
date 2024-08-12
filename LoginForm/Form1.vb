Public Class Form1
    Dim pass As String = "password"
    Dim asterisk As String = "********"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub hidepasslogo_Click(sender As Object, e As EventArgs) Handles hidepasslogo.Click
        showpasslogo.Visible = True
        hidepasslogo.Visible = False
        passwordtextbox.Text = asterisk
    End Sub

    Private Sub showpasslogo_Click(sender As Object, e As EventArgs) Handles showpasslogo.Click
        showpasslogo.Visible = False
        hidepasslogo.Visible = True
        passwordtextbox.Text = pass
    End Sub
End Class
