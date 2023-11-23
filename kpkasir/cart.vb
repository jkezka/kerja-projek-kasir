Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class cart

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Private hargaBarang As Integer
    Private quantity As Integer
    Private totalHarga As Decimal = 0

    Private Sub cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konekdb()

        Try
            If jumlah.Text = "" Then
            Else
                Dim EditData As String = "Update cart set quantity='" & jumlah.Text & "'"
                CMd = New OdbcCommand(EditData, Conn)
                CMd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", MsgBoxStyle.Information, "Informasi")
            End If

            Dim query As String = "SELECT nama, harga, quantity, subtotal FROM cart"
            Dim adapter As New OdbcDataAdapter(query, Conn)
            Dim ds As New DataSet()
            adapter.Fill(ds, "cart")

            dgv.DataSource = ds.Tables("cart")

            HitungTotalHarga()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try

        AddBottomBorder(jumlah)
        AddBottomBorder(bayar)
        AddBottomBorder(kembalian)
        nama.BorderStyle = BorderStyle.None
        harga.BorderStyle = BorderStyle.None
        jumlah.BorderStyle = BorderStyle.None
        subtotal.BorderStyle = BorderStyle.None
        total.BorderStyle = BorderStyle.None
        bayar.BorderStyle = BorderStyle.None
        kembalian.BorderStyle = BorderStyle.None
    End Sub

    Private Sub AddBottomBorder(textBox As TextBox)
        Dim borderBottom As New Panel()
        borderBottom.BackColor = Color.FromArgb(28, 21, 13)
        borderBottom.Dock = DockStyle.Bottom
        borderBottom.Height = 1
        textBox.Controls.Add(borderBottom)
    End Sub

    Private Sub UpdateSubtotal()
        If Integer.TryParse(harga.Text, hargaBarang) AndAlso Integer.TryParse(jumlah.Text, quantity) Then
            Dim subtotalValue As Integer = hargaBarang * quantity
            subtotal.Text = subtotalValue.ToString()
        End If
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgv.Rows(e.RowIndex)

            nama.Text = dgv.Rows(e.RowIndex).Cells(0).Value
            harga.Text = dgv.Rows(e.RowIndex).Cells(1).Value
            jumlah.Text = dgv.Rows(e.RowIndex).Cells(2).Value
            subtotal.Text = dgv.Rows(e.RowIndex).Cells(3).Value

            UpdateSubtotal()
        End If
    End Sub

    Private Sub HitungTotalHarga()
        totalHarga = 0

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim subtotalValue As Decimal = 0
                If Decimal.TryParse(row.Cells("subtotal").Value.ToString(), subtotalValue) Then
                    totalHarga += subtotalValue
                End If
            End If
        Next

        total.Text = totalHarga.ToString()
    End Sub

    Private jumlahUang As Decimal = 0
    Private kembalianValue As Decimal = 0

    Private Sub RefreshData()
        Try
            Call Konekdb()

            Dim query As String = "SELECT nama, harga, quantity, subtotal FROM cart"
            Dim adapter As New OdbcDataAdapter(query, Conn)
            Dim ds As New DataSet()
            adapter.Fill(ds, "cart")

            dgv.DataSource = ds.Tables("cart")

            HitungTotalHarga()
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        HitungKembalian()
    End Sub

    Private Sub HitungKembalian()
        Dim totalHarga As Decimal

        If Decimal.TryParse(total.Text, totalHarga) AndAlso Decimal.TryParse(bayar.Text, jumlahUang) Then
            kembalianValue = jumlahUang - totalHarga
            kembalian.Text = kembalianValue.ToString()
        Else
            kembalian.Text = "Invalid Input"
        End If
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Call Konekdb()

            If dgv.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgv.SelectedRows(0)
                Dim idToUpdate As String = selectedRow.Cells("nama").Value.ToString()

                Dim hargaBarang As Integer
                Dim quantity As Integer
                Dim subtotalValue As Integer

                If Integer.TryParse(harga.Text, hargaBarang) AndAlso Integer.TryParse(jumlah.Text, quantity) Then
                    subtotalValue = hargaBarang * quantity
                    subtotal.Text = subtotalValue.ToString()

                    Dim EditData As String = "UPDATE cart SET harga='" & hargaBarang & "', quantity='" & quantity & "', subtotal='" & subtotalValue & "' WHERE nama = '" & idToUpdate & "'"
                    CMd = New OdbcCommand(EditData, Conn)
                    CMd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Diedit", MsgBoxStyle.Information, "Informasi")
                Else
                    MsgBox("Data harga, jumlah, atau subtotal tidak valid.")
                End If
            Else
                MsgBox("Pilih baris yang ingin diedit terlebih dahulu.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try

        HitungTotalHarga()
        RefreshData()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call Konekdb()

            If dgv.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgv.SelectedRows(0)
                Dim idToDelete As String = selectedRow.Cells("nama").Value.ToString()

                Dim HapusData As String = "DELETE FROM cart WHERE nama = '" & idToDelete & "'"
                CMd = New OdbcCommand(HapusData, Conn)
                CMd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Pilih baris yang ingin dihapus terlebih dahulu.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try

        HitungTotalHarga()
        RefreshData()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        minuman.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsValidPayment() Then
            Try
                PPD.Document = PD
                PPD.ShowDialog()
                'PD.Print()

                ' Setelah mencetak, hapus semua data dari tabel cart
                HapusSemuaDataCart()
                RefreshData()
            Catch ex As Exception
                MessageBox.Show("Error during printing: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Jumlah uang yang dimasukkan kurang dari total pembelian. Mohon masukkan jumlah uang yang cukup.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub HapusSemuaDataCart()
        Try
            Call Konekdb()

            Dim HapusData As String = "DELETE FROM cart"
            CMd = New OdbcCommand(HapusData, Conn)
            CMd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Function IsValidPayment() As Boolean
        Dim totalHarga As Decimal

        If Decimal.TryParse(total.Text, totalHarga) AndAlso Decimal.TryParse(bayar.Text, jumlahUang) Then
            Return jumlahUang >= totalHarga
        End If

        Return False
    End Function

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim backgroundColor As Color = Color.AntiqueWhite
        Dim rect As New Rectangle(0, 0, e.PageSettings.PrintableArea.Width, e.PageSettings.PrintableArea.Height)
        Using brush As New SolidBrush(backgroundColor)
            e.Graphics.FillRectangle(brush, rect)
        End Using
        Dim logo As New Font("Freestyle Script", 16, FontStyle.Regular)
        Dim f5 As New Font("Footlight MT Light", 5, FontStyle.Regular)
        Dim f6 As New Font("Footlight MT Light", 6, FontStyle.Regular)
        Dim f7 As New Font("Footlight MT Light", 7, FontStyle.Regular)
        Dim f12 As New Font("Footlight MT Light", 12, FontStyle.Bold)

        Dim garis As String
        garis = "----------------------------------------------------------------------"

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim tanggalStruk As String = DateTime.Now.ToString("dd/MM/yyyy")
        e.Graphics.DrawString(tanggalStruk, f5, New SolidBrush(Color.FromArgb(28, 21, 13)), 245, 5, kanan)

        e.Graphics.DrawString("La Note", f12, New SolidBrush(Color.FromArgb(28, 21, 13)), centermargin, 18, tengah)

        e.Graphics.DrawString("Telp.", f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 55)
        e.Graphics.DrawString("0123456789", f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 185, 55)
        e.Graphics.DrawString("Alamat", f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 65)
        e.Graphics.DrawString("Jl. Anggur No. 123 ", f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 168, 65)

        e.Graphics.DrawString(garis, f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 5, 78)

        e.Graphics.DrawString("Menu", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 88)
        e.Graphics.DrawString("Subtotal", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 200, 88)

        e.Graphics.DrawString(garis, f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 5, 98)

        Dim tinggi As Integer

        For baris As Integer = 0 To dgv.RowCount - 1

            Dim cellValue = dgv.Rows(baris)?.Cells(0)?.Value
            If cellValue IsNot Nothing Then
                e.Graphics.DrawString(cellValue.ToString(), f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 120 + tinggi)
            End If

            Dim cellValueQty = dgv.Rows(baris)?.Cells(2)?.Value
            Dim cellValueHarga = dgv.Rows(baris)?.Cells(1)?.Value
            If cellValueQty IsNot Nothing AndAlso cellValueHarga IsNot Nothing Then
                e.Graphics.DrawString($"{cellValueQty} x Rp {cellValueHarga}", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 130 + tinggi)
            End If

            Dim cellValueSubtotal = dgv.Rows(baris)?.Cells(3)?.Value
            If cellValueSubtotal IsNot Nothing Then
                Dim formatRight As New StringFormat() With {.Alignment = StringAlignment.Far}
                e.Graphics.DrawString($"Rp {cellValueSubtotal}", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 236, 120 + tinggi, formatRight)
            End If

            tinggi += 30
        Next

        tinggi -= 40
        e.Graphics.DrawString(garis, f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 5, 135 + tinggi)
        e.Graphics.DrawString("Total", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 151 + tinggi)
        Dim formatRight2 As New StringFormat() With {.Alignment = StringAlignment.Far}
        e.Graphics.DrawString("Rp " + Format(totalHarga), f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 236, 151 + tinggi, formatRight2)

        e.Graphics.DrawString("Tunai", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 166 + tinggi)
        e.Graphics.DrawString("Rp " + Format(jumlahUang), f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 236, 166 + tinggi, formatRight2)

        e.Graphics.DrawString("Kembali", f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 13, 181 + tinggi)
        e.Graphics.DrawString("Rp " + Format(kembalianValue), f7, New SolidBrush(Color.FromArgb(28, 21, 13)), 236, 181 + tinggi, formatRight2)

        e.Graphics.DrawString(garis, f6, New SolidBrush(Color.FromArgb(28, 21, 13)), 5, 197 + tinggi)

        e.Graphics.DrawString(ChrW(&H201D) & " THANK YOU FOR YOUR ORDER " & ChrW(&H201D), f7, New SolidBrush(Color.FromArgb(28, 21, 13)), centermargin, 225 + tinggi, tengah)

        e.Graphics.DrawString("La Matinée Café", logo, New SolidBrush(Color.FromArgb(28, 21, 13)), centermargin, 450, tengah)
    End Sub
End Class
