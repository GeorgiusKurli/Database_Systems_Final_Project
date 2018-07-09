Imports MySql.Data.MySqlClient
Public Class admin_modify

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
    Dim place_result_search As Integer
    Dim restaurant_result_search As Integer
    Dim restaurant As String
    Dim restaurantid As Integer
    Dim rating As String
    Dim hour As String
    Dim contact As String
    Dim street As String
    Dim locationid As Integer
    Dim city As String
    Dim cityid As Integer
    Dim type As String
    Dim typeid As Integer
    Dim menus As String
    Dim menusid As Integer

    Private Sub commit_button_Click(sender As Object, e As EventArgs) Handles commit_button.Click
        Try
            conn.Open()
            restaurant_search = res_search_textbox.Text()
            street_search = street_search_textbox.Text()
            city_search = city_search_textbox.Text()

            query = "select main.ID, main.RestaurantID from main, restaurant, location, city where main.RestaurantID = restaurant.RestaurantID and restaurant.RestaurantName = '" + restaurant_search + "' and main.LocationID = location.LocationID and location.StreetName = '" + street_search + "' and location.CityID = city.CityID and city.CityName = '" + city_search + "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader

            If reader.Read() Then
                place_result_search = CInt(reader("ID"))
                restaurant_result_search = CInt(reader("RestaurantID"))
                conn.Close()
            Else
                Throw New System.Exception("Restaurant not found")
            End If

            conn.Open()
            city = city_textbox.Text()
            query = "select CityID from city where CityName = '" + city + "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            If reader.Read() Then
                cityid = CInt(reader("CityID"))
                conn.Close()
            Else
                conn.Close()

                conn.Open()
                query = "insert into city(CityName) values('" + city + "')"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                conn.Close()

                conn.Open()
                query = "select CityID from city where CityName = '" + city + "'"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                reader.Read()
                cityid = CInt(reader("CityID"))
                conn.Close()
            End If

            conn.Open()
            street = street_textbox.Text()
            query = "select LocationID from location where StreetName = '" + street + "' and CityID = " + CStr(cityid)
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            If reader.Read() Then
                locationid = CInt(reader("LocationID"))
                conn.Close()
            Else
                conn.Close()

                conn.Open()
                query = "insert into location(StreetName, CityID) values('" + street + "', " + CStr(cityid) + ")"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                conn.Close()

                conn.Open()
                query = "select LocationID from location where StreetName = '" + street + "' and CityID = " + CStr(cityid)
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                reader.Read()
                locationid = CInt(reader("LocationID"))
                conn.Close()
            End If

            conn.Open()
            menus = menu_textbox.Text()
            query = "select MenuID from menu where MenuName = '" + menus + "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            If reader.Read() Then
                menusid = CInt(reader("MenuID"))
                conn.Close()
            Else
                conn.Close()

                conn.Open()
                query = "insert into menu(MenuName) values('" + menus + "')"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                conn.Close()

                conn.Open()
                query = "select MenuID from menu where MenuName = '" + menus + "'"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                reader.Read()
                menusid = CInt(reader("MenuID"))
                conn.Close()
            End If

            conn.Open()
            type = type_textbox.Text()
            query = "select TypeID from type where RestaurantType = '" + type + "'"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            If reader.Read() Then
                typeid = CInt(reader("TypeID"))
                conn.Close()
            Else
                conn.Close()

                conn.Open()
                query = "insert into type(RestaurantType) values('" + type + "')"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                conn.Close()

                conn.Open()
                query = "select TypeID from type where RestaurantType = '" + type + "'"
                comm = New MySqlCommand(query, conn)
                reader = comm.ExecuteReader()
                reader.Read()
                typeid = CInt(reader("TypeID"))
                conn.Close()
            End If

            conn.Open()
            restaurant = res_textbox.Text()
            contact = contact_textbox.Text()
            query = "update restaurant set RestaurantName = '" + restaurant + "', RestaurantContact = '" + contact + "', TypeID = " + CStr(typeid) + ", MenuID = " + CStr(menusid) + " where RestaurantID = " + CStr(restaurant_result_search)
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()
            conn.Close()

            conn.Open()
            rating = rating_textbox.Text()
            hour = hour_textbox.Text()
            query = "update main set Rating = " + rating + ", Hours = '" + hour + "', LocationID = " + CStr(locationid) + " where ID = " + CStr(place_result_search)
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()
            MessageBox.Show("Successfully modified")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

        res_textbox.Clear()
        contact_textbox.Clear()
        hour_textbox.Clear()
        rating_textbox.Clear()
        street_textbox.Clear()
        city_textbox.Clear()
        type_textbox.Clear()
        menu_textbox.Clear()
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