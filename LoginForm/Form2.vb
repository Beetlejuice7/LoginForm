Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2
    Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=LOGIN;Persist Security Info=True;User ID=SA;Password=MyStrongPass123;"
    'Dim ename As String = nametxt.Text
    'Dim esurname As String = surnametxt.Text
    'Dim econtact As String = contacttxt.Text
    'Dim eeamil As String = emailtxt.Text
    'Dim eusername As String = usernametxt.Text
    'Dim epassword As String = passwordtxt.Text
    Private Sub signup_Click(sender As Object, e As EventArgs) Handles signup.Click

        Try
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "INSERT INTO userdetails (name,surname, contact, email, username, password) values (@name, @surname, @contact, @email, @username, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@name", nametxt.Text)
                    command.Parameters.AddWithValue("@surname", surnametxt.Text)
                    command.Parameters.AddWithValue("@contact", contacttxt.Text)
                    command.Parameters.AddWithValue("@email", emailtxt.Text)
                    command.Parameters.AddWithValue("@username", usernametxt.Text)
                    command.Parameters.AddWithValue("@password", passwordtxt.Text)

                    Dim rowsaffected As Integer = command.ExecuteNonQuery()
                    If rowsaffected > 0 Then
                        MessageBox.Show("User registered successfully!")
                    Else
                        MessageBox.Show("Registration Failed. please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message)
        End Try
    End Sub
End Class