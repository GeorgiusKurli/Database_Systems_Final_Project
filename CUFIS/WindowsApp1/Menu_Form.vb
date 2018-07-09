Imports MySql.Data.MySqlClient

Public Class Menu_Form
    Friend Shared menu_id As String
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim conn As MySqlConnection = New MySqlConnection("server = localhost; uid = root; pwd = ; database = cufis; SslMode = none")
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String
    Dim line As String

    'Menu Form loading implementation
    Private Sub Menu_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restaurant_label.Text = Specifics_Form.restaurant_name & " " & Specifics_Form.street_name & "'s Menu"

        Try
            conn.Open()

            'Query to get everything from dishes table based on ID
            query = "SELECT * FROM Dishes WHERE MenuID = " & menu_id

            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            'Loop used to get everything from table
            Do While reader.Read()

                'Concantenating string and adding it into dish list box
                line = reader("DishName") & " " & reader("DishPrice") & " RP"
                dish_listbox.Items.Add(line)

            Loop
            conn.Close()

            conn.Open()

            'Query to get everything from beverages table based on ID
            query = "SELECT * FROM Beverages WHERE MenuID = " & menu_id

            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            'Loop used to get everything from table
            Do While reader.Read()

                'Concantenating string and adding it into beverage list box
                line = reader("BeverageName") & " " & reader("BeveragePrice") & " RP"
                beverage_listbox.Items.Add(line)

            Loop
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
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