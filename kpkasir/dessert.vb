Imports MySql.Data.MySqlClient

Public Class dessert

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        sarapan.Show()
    End Sub

    Private Sub dessert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konekdb()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox1.Text, quantity) Then

            Dim harga As Integer = 15000

            Dim nama As String = "Crème Brûlée"

            Dim subtotal As Integer = harga * quantity

            Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir"

            Dim query As String = "INSERT INTO cart (nama, harga, quantity, subtotal) VALUES (@nama, @harga, @quantity, @subtotal)"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama", nama)
                    command.Parameters.AddWithValue("@harga", harga)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@subtotal", subtotal)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show(quantity.ToString() & " Crème Brûlée berhasil ditambahkan ke dalam keranjang.")

                    Catch ex As Exception
                        'MessageBox.Show("Error: " & ex.ToString())
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Masukkan jumlah menu")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox4.Text, quantity) Then

            Dim harga As Integer = 25000

            Dim nama As String = "Macarons"

            Dim subtotal As Integer = harga * quantity

            Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir"

            Dim query As String = "INSERT INTO cart (nama, harga, quantity, subtotal) VALUES (@nama, @harga, @quantity, @subtotal)"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama", nama)
                    command.Parameters.AddWithValue("@harga", harga)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@subtotal", subtotal)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show(quantity.ToString() & " Macarons berhasil ditambahkan ke dalam keranjang.")
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.ToString())
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Masukkan jumlah menu")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox5.Text, quantity) Then

            Dim harga As Integer = 12000

            Dim nama As String = "Profiteroles"

            Dim subtotal As Integer = harga * quantity

            Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir"

            Dim query As String = "INSERT INTO cart (nama, harga, quantity, subtotal) VALUES (@nama, @harga, @quantity, @subtotal)"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama", nama)
                    command.Parameters.AddWithValue("@harga", harga)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@subtotal", subtotal)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show(quantity.ToString() & " Profiteroles berhasil ditambahkan ke dalam keranjang.")
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.ToString())
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Masukkan jumlah menu")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox2.Text, quantity) Then

            Dim harga As Integer = 22000

            Dim nama As String = "Éclairs"

            Dim subtotal As Integer = harga * quantity

            Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir"

            Dim query As String = "INSERT INTO cart (nama, harga, quantity, subtotal) VALUES (@nama, @harga, @quantity, @subtotal)"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama", nama)
                    command.Parameters.AddWithValue("@harga", harga)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@subtotal", subtotal)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show(quantity.ToString() & " Éclairs berhasil ditambahkan ke dalam keranjang.")
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.ToString())
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Masukkan jumlah menu")
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Close()
        cart.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim intResponse As Integer
        intResponse = MsgBox("Anda Yakin Ingin Keluar?",
        vbYesNo + vbQuestion, "Peringatan")
        If intResponse = vbYes Then
            Me.Close()
            FormLogin.Show()
            MsgBox("Anda Berhasil Keluar", MsgBoxStyle.MsgBoxRight, "Perhatian")
        End If
    End Sub
End Class