Imports MySql.Data.MySqlClient

Public Class Admin_Menu

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim line As String

    Private Sub Admin_Menu_load(sender As Object, e As EventArgs) Handles MyBase.Load
        admin_label.Text() = "Welcome " + global_username
        Me.Reprint()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_button.Click
        Me.Hide()
        admin_add.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles modify_button.Click
        Me.Hide()
        admin_modify.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles del_button.Click
        Me.Hide()
        admin_del.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Taking item selected, converting it into string and storing it in item
        Dim item As String = ListBox1.SelectedItem.ToString()

        'Splitting item by empty space and storing it into words
        Dim words As String() = item.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)

        'Flag for when restaurant_name starts
        Dim flag1 As Boolean = False

        'Flag for when street_name address starts
        Dim flag2 As Boolean = False

        Dim restaurant_name As String = ""
        Dim address As String = ""
        Dim dec As Decimal

        'Looping through the words array
        For Each word In words

            'Setting flag2 to true when word reaches Jl.
            If word.Equals("Jl.") Then
                flag2 = True
            End If


            If flag1.Equals(True) And flag2.Equals(False) Then
                'Appending words into restaurant name
                restaurant_name = restaurant_name & " " & word

            ElseIf flag1.Equals(True) And flag2.Equals(True) Then
                'Appending words into address
                address = address & " " & word

            End If

            'Setting flag1 to true when word reaches a decimal number
            If Decimal.TryParse(word, dec) Then
                flag1 = True
            End If
        Next

        'Setting variables for Specifics_Form
        Specifics_Form.restaurant_name = restaurant_name
        Specifics_Form.street_name = address
        Specifics_Form.Show()
        Me.Hide()
    End Sub

    Public Sub Reprint()
        Try
            conn.Open()

            'Clear all items in the listbox
            ListBox1.Items.Clear()

            'Query to find necessary data ordered by 'Rating'
            comm = New MySqlCommand("select main.Rating, restaurant.RestaurantName, location.StreetName From main INNER JOIN restaurant ON main.RestaurantID = restaurant.restaurantID INNER JOIN location ON main.locationID = location.locationID ORDER BY Rating DESC", conn)
            reader = comm.ExecuteReader()

            'Loop 10 times to print the first 10 restaurant
            While reader.Read()

                'Concatenating data
                line = reader("Rating") & " " & reader("RestaurantName") & " " & reader("StreetName")

                'Adding 'line' string into the listbox
                ListBox1.Items.Add(line)

            End While
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub out_button_Click(sender As Object, e As EventArgs) Handles out_button.Click
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