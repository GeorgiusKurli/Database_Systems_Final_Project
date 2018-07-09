Imports MySql.Data.MySqlClient
Public Class admin_del

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    Dim restaurant_search As String
    Dim street_search As String
    Dim city_search As String
    Dim result_search As Integer

    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Try
            conn.Open()
            restaurant_search = res_search_textbox.Text()
            street_search = street_search_textbox.Text()
            city_search = city_search_textbox.Text()

            query = "select main.ID from main, restaurant, location, city where main.RestaurantID = restaurant.RestaurantID and restaurant.RestaurantName = '" + restaurant_search + "' and main.LocationID = location.LocationID and location.StreetName = '" + street_search + "' and location.CityID = city.CityID and city.CityName = '" + city_search + "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader

            If reader.Read() Then
                result_search = CInt(reader("ID"))
                conn.Close()

                conn.Open()
                query = "delete from main where ID = " + CStr(result_search)
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                conn.Close()
                MessageBox.Show("Successfully deleted")
            Else
                Throw New System.Exception("Restaurant not found")
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

        res_search_textbox.Clear()
        street_search_textbox.Clear()
        city_search_textbox.Clear()
    End Sub

    Private Sub back_button_Click(sender As Object, e As EventArgs) Handles back_button.Click
        Admin_Menu.Show()
        Admin_Menu.Reprint()
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