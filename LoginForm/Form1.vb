Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim pass As String = "password"
    Dim asterisk As String = "********"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePlaceholder()

    End Sub
    Private Sub InitializePlaceholder()
        usernametextbox.Text = "Enter username"
        passwordtextbox.Text = "Enter password"
        passwordtextbox.PasswordChar = ""
        usernametextbox.ForeColor = Color.Gray
        passwordtextbox.ForeColor = Color.Gray
        Me.ActiveControl = wallpaper
    End Sub

    Private Sub hidepasslogo_Click(sender As Object, e As EventArgs) Handles hidepasslogo.Click
        showpasslogo.Visible = True
        hidepasslogo.Visible = False
        passwordtextbox.PasswordChar = "*"
    End Sub

    Private Sub showpasslogo_Click(sender As Object, e As EventArgs) Handles showpasslogo.Click
        showpasslogo.Visible = False
        hidepasslogo.Visible = True
        'passwordtextbox.Text = pass
        'passwordtextbox.Text = passwordtextbox.Text
        passwordtextbox.PasswordChar = ""
    End Sub

    Private Sub usernametextbox_Enter(sender As Object, e As EventArgs) Handles usernametextbox.Enter
        If usernametextbox.Text = "Enter username" Then
            usernametextbox.Text = ""
            usernametextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usernametextbox_Leave(sender As Object, e As EventArgs) Handles usernametextbox.Leave
        If String.IsNullOrEmpty(usernametextbox.Text) Then
            usernametextbox.Text = "Enter username"
            usernametextbox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub passwordtextbox_Enter(sender As Object, e As EventArgs) Handles passwordtextbox.Enter
        If passwordtextbox.Text = "Enter password" Then
            passwordtextbox.Text = ""
            passwordtextbox.PasswordChar = "*"
            passwordtextbox.ForeColor = Color.Black
        End If
        hideit.Visible = False
    End Sub

    Private Sub passwordtextbox_Leave(sender As Object, e As EventArgs) Handles passwordtextbox.Leave
        If String.IsNullOrEmpty(passwordtextbox.Text) Then
            passwordtextbox.Text = "Enter password"
            passwordtextbox.PasswordChar = ""
            passwordtextbox.ForeColor = Color.Gray
        End If

        If passwordtextbox.Text = "Enter password" Then
            showpasslogo.Visible = True
            hideit.Visible = True
        End If
    End Sub

    Private Sub showpasslogo_MouseHover(sender As Object, e As EventArgs) Handles showpasslogo.MouseHover
        showpasslogo.Size = New Size(19, 20)
    End Sub

    Private Sub showpasslogo_MouseLeave(sender As Object, e As EventArgs) Handles showpasslogo.MouseLeave
        showpasslogo.Size = New Size(17, 18)
    End Sub

    Private Sub hidepasslogo_MouseHover(sender As Object, e As EventArgs) Handles hidepasslogo.MouseHover
        hidepasslogo.Size = New Size(19, 20)
    End Sub

    Private Sub hidepasslogo_MouseLeave(sender As Object, e As EventArgs) Handles hidepasslogo.MouseLeave
        hidepasslogo.Size = New Size(17, 18)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles wallpaper.Click, PictureBox3.Click, MyBase.Click, inputarea.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

    End Sub
End Class
