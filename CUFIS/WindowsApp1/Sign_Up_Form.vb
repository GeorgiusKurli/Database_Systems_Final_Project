Imports MySql.Data.MySqlClient

Public Class Sign_Up_Form
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    'Sign up button implementation
    Private Sub sign_up_button_Click(sender As Object, e As EventArgs)

        'Getting all string from text box and storing them in variables
        Dim username As String = username_textbox.Text
        Dim password As String = password_textbox.Text
        Dim confirm As String = confirm_textbox.Text
        Dim email As String = email_textbox.Text
        Dim contact As String = contact_textbox.Text
        Dim street_name As String = street_textbox.Text
        Dim city As String = (city_id_textbox.Text).Trim
        Dim city_id As String

        'Checks if password matches confirm
        If password.Equals(confirm) Then
            Try
                conn.Open()
                'Query for username given
                comm = New MySqlCommand("SELECT * FROM users WHERE UserName = '" + username + "'", conn)
                reader = comm.ExecuteReader()

                'if reader.read() is applicable, username is used
                If reader.Read() Then
                    MessageBox.Show("Username is used")
                Else
                    conn.Close()

                    conn.Open()
                    'Query for city given
                    comm = New MySqlCommand("SELECT * FROM city WHERE CityName = '" & city & "'", conn)
                    reader = comm.ExecuteReader()

                    'Checks if city given exists in database
                    If reader.Read() Then

                        'Getting city id from table
                        city_id = reader("cityID")

                        conn.Close()

                    Else
                        conn.Close()
                        'Insert new city into city table
                        conn.Open()
                        comm = New MySqlCommand("INSERT INTO city (CityName) VALUES ('" & city & "')", conn)
                        reader = comm.ExecuteReader()
                        conn.Close()

                        'Get city id from city table
                        conn.Open()
                        comm = New MySqlCommand("SELECT * FROM city WHERE CityName = '" & city & "'", conn)
                        reader = comm.ExecuteReader()
                        city_id = reader("cityID")
                        conn.Close()

                    End If

                    conn.Open()

                    'Inserting new user into database
                    comm = New MySqlCommand("INSERT INTO users (UserName, Password, UserStreetName, CityID) VALUES ('" + username + "', '" + password + "', '" + street_name + "', " + city_id + ")", conn)
                    reader = comm.ExecuteReader()
                    MessageBox.Show("Signup Successful")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)

            End Try
            conn.Close()

        Else
            MessageBox.Show("Passwords does not match")
        End If

    End Sub

    'Back button implementation
    Private Sub back_button_Click(sender As Object, e As EventArgs)
        Login_Form.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

End Class