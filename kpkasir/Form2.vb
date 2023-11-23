Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konekdb()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Da = New Odbc.OdbcDataAdapter("Select * from menu", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "menu")
        DGV.DataSource = Ds.Tables("menu")
        DGV.ReadOnly = True
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class