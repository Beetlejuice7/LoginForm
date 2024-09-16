Imports System.Data.SqlClient
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
    'For inserting data in database
    'Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

    '    ' Replace with your actual database connection string
    '    Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=LOGIN;User ID=SA;Password=MyStrongPass123;Encrypt=True;TrustServerCertificate=True"

    '    ' Get the entered username and password
    '    Dim enteredUsername As String = usernametextbox.Text
    '    Dim enteredPassword As String = passwordtextbox.Text

    '    Try
    '        ' Establish a connection to the database
    '        Using connection As New SqlConnection(connectionString)
    '            connection.Open()

    '            ' SQL query to insert the username and password
    '            Dim query As String = "INSERT INTO login (username, password) VALUES (@Username, @Password)"

    '            ' Create a SqlCommand to execute the query
    '            Using command As New SqlCommand(query, connection)
    '                ' Add parameters to avoid SQL injection attacks
    '                command.Parameters.AddWithValue("@Username", enteredUsername)
    '                command.Parameters.AddWithValue("@Password", enteredPassword)

    '                ' Execute the query
    '                Dim rowsAffected As Integer = command.ExecuteNonQuery()

    '                ' Check if the insert was successful
    '                If rowsAffected > 0 Then
    '                    MessageBox.Show("User registered successfully!")
    '                Else
    '                    MessageBox.Show("Registration failed. Please try again.")
    '                End If
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Handle any errors that occur during the database connection or query execution
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        ' Replace with your actual database connection string
        Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=LOGIN;User ID=SA;Password=MyStrongPass123;Encrypt=True;TrustServerCertificate=True"

        ' Get the entered username and password from the textboxes
        Dim enteredUsername As String = usernametextbox.Text
        Dim enteredPassword As String = passwordtextbox.Text

        Try
            ' Establish a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' SQL query to check if the username and password exist in the database
                Dim query As String = "SELECT COUNT(*) FROM login WHERE username = @Username AND password = @Password"

                ' Create a SqlCommand to execute the query
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", enteredUsername)
                    command.Parameters.AddWithValue("@Password", enteredPassword)

                    ' Execute the query and get the number of matching records
                    Dim userCount As Integer = CInt(command.ExecuteScalar())

                    ' Check if the credentials are correct
                    If userCount > 0 Then
                        MessageBox.Show("Login successful!")
                    Else
                        MessageBox.Show("Invalid username or password. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during the database connection or query execution
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub signuplabel_MouseHover(sender As Object, e As EventArgs) Handles signuplabel.MouseHover
        signuplabel.ForeColor = Color.Blue
    End Sub

    Private Sub signuplabel_MouseLeave(sender As Object, e As EventArgs) Handles signuplabel.MouseLeave
        signuplabel.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub forgetpasslabel_MouseHover(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseHover
        forgetpasslabel.ForeColor = Color.Blue
    End Sub

    Private Sub forgetpasslabel_MouseLeave(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseLeave
        forgetpasslabel.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub signuplabel_Click(sender As Object, e As EventArgs) Handles signuplabel.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
