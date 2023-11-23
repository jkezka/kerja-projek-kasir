Imports MySql.Data.MySqlClient

Public Class minuman
    Private Sub minuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konekdb()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sarapan.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Mengambil nilai dari TextBox1 (quantity)
        Dim quantity As Integer
        If Integer.TryParse(TextBox1.Text, quantity) Then
            ' Periksa apakah quantity lebih besar dari 0
            If quantity > 0 Then
                ' Harga item (misalnya 22000)
                Dim harga As Integer = 22000

                ' Nama item (misalnya "Café au Lait")
                Dim nama As String = "Café au Lait"

                ' Total harga item (harga * quantity)
                Dim subtotal As Integer = harga * quantity

                ' Menyimpan item ke dalam database tabel "cart"
                Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir" ' Ganti dengan connection string Anda
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
                            MessageBox.Show(quantity.ToString() & " Café au Lait berhasil ditambahkan ke dalam keranjang.")
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.ToString())
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Masukkan jumlah menu di atas 0.")
            End If
        Else
            MessageBox.Show("Masukkan jumlah menu.")
        End If
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox5.Text, quantity) Then
            ' Periksa apakah quantity lebih besar dari 0
            If quantity > 0 Then
                ' Harga item (misalnya 22000)
                Dim harga As Integer = 18000

                ' Nama item (misalnya "Café au Lait")
                Dim nama As String = "Espresso"

                ' Total harga item (harga * quantity)
                Dim subtotal As Integer = harga * quantity

                ' Menyimpan item ke dalam database tabel "cart"
                Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=;Database=kasir" ' Ganti dengan connection string Anda
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
                            MessageBox.Show(quantity.ToString() & " Espresso berhasil ditambahkan ke dalam keranjang.")
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.ToString())
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Masukkan jumlah menu di atas 0.")
            End If
        Else
            MessageBox.Show("Masukkan jumlah menu.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox4.Text, quantity) Then

            If quantity > 0 Then

                Dim harga As Integer = 20000
                Dim nama As String = "Café Crème"
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
                            MessageBox.Show(quantity.ToString() & " Café Crème berhasil ditambahkan ke dalam keranjang.")
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.ToString())
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Masukkan jumlah menu di atas 0.")
            End If
        Else
            MessageBox.Show("Masukkan jumlah menu.")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim quantity As Integer
        If Integer.TryParse(TextBox2.Text, quantity) Then

            If quantity > 0 Then

                Dim harga As Integer = 25000
                Dim nama As String = "Chocolat Chaud"
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
                            MessageBox.Show(quantity.ToString() & " Chocolat Chaud berhasil ditambahkan ke dalam keranjang.")
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.ToString())
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Masukkan jumlah menu di atas 0.")
            End If
        Else
            MessageBox.Show("Masukkan jumlah menu.")
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
