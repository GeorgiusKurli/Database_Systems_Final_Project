Imports MySql.Data.MySqlClient

Public Class Specifics_Form

    'Variables used so that other forms can pass variables to this form
    Friend Shared restaurant_name As String
    Friend Shared street_name As String

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    'Form loading implementation
    Private Sub Specifics_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restaurant_name = restaurant_name.Trim
        street_name = street_name.Trim

        'Setting labels' text
        restaurant.Text = restaurant_name
        street.Text = street_name


        Try
            conn.Open()

            'Query used to get everything from Restaurant, Main and Location
            query = "select * From main INNER JOIN restaurant ON main.RestaurantID = restaurant.restaurantID INNER JOIN location ON main.locationID = location.locationID WHERE restaurant.RestaurantName = '" & restaurant.Text & "' and StreetName = '" & street.Text & "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()
            reader.Read()

            'Setting labels
            rating.Text = reader("Rating")
            open.Text = reader("Hours")
            contact.Text = reader("RestaurantContact")

            'Getting IDs and storing them
            Dim cityid As Integer = reader("CityID")
            Dim typeid As Integer = reader("TypeID")

            'Passing MenuID to Menu Form
            Menu_Form.menu_id = reader("MenuID")
            conn.Close()

            conn.Open()

            'Query to find specific city based on ID
            query = "SELECT * FROM city WHERE CityID = " & cityid
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()
            reader.Read()
            city.Text = reader("CityName")
            conn.Close()

            conn.Open()

            'Query to find specific type based on ID
            query = "SELECT * FROM type WHERE typeID = " & typeid
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()
            reader.Read()
            type.Text = reader("RestaurantType")

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try

        conn.Close()
    End Sub

    'Back button implementation
    Private Sub back_button_Click(sender As Object, e As EventArgs) Handles back_button.Click
        If global_accessor_bool.Equals(True) Then
            Admin_Menu.Show()
            Admin_Menu.Reprint()
            Me.Close()
        Else
            User_Menu.Show()
            Me.Close()
        End If

    End Sub

    'Menu button implementation
    Private Sub menu_button_Click(sender As Object, e As EventArgs) Handles menu_button.Click
        Menu_Form.Show()
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