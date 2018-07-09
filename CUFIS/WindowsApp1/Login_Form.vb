Imports MySql.Data.MySqlClient

'Used for setting who is logged in
Module GlobalVariables
    Public global_username As String
    Public global_accessor_bool As Boolean
End Module

'Main login form
Public Class Login_Form
    'Variable for panel drag
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    'Standard variables for connecting and executing queries in mysql
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    'Implementation for signup_button
    Private Sub signup_button_Click(sender As Object, e As EventArgs) Handles signup_button.Click
        'Closes login_form and shows the sign_up_form
        Me.Hide()
        Sign_Up_Form.Show()

    End Sub

    'Implementation for signin_button
    Private Sub signin_button_Click(sender As Object, e As EventArgs) Handles signin_button.Click

        'Get text from textboxes and save it into respective variables
        Dim username As String = username_textbox.Text
        Dim password As String = password_textbox.Text

        Try
            'Open connection to query
            conn.Open()

            If admin_tick.Checked Then
                comm = New MySqlCommand("SELECT * FROM admins WHERE AdminName = '" + username + "'", conn)
            Else
                comm = New MySqlCommand("SELECT * FROM users WHERE UserName = '" + username + "'", conn)
            End If

            reader = comm.ExecuteReader()
            reader.Read()

            'checks if password given is equal to password created when signup
            If reader("Password").Equals(password) Then
                MessageBox.Show("Sign in Successful")
                global_username = username
                Me.Hide()
                username_textbox.Clear()
                password_textbox.Clear()
                If admin_tick.Checked Then
                    global_accessor_bool = True
                    conn.Close()
                    Admin_Menu.Show()
                Else
                    global_accessor_bool = False
                    conn.Close()
                    User_Menu.Show()
                End If
            Else
                MessageBox.Show("Incorrect Password")
            End If

        Catch ex As Exception
            'if reader.Read() does not find anything, a message will say username does not exist.
            MessageBox.Show("Username does not exist")

        End Try
        conn.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

End Class
