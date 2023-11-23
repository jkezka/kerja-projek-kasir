Imports System.Data.Odbc

Public Class FormLogin
    Private isPasswordVisible As Boolean = False

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.PasswordChar = "*"
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Masukkan Username atau Password")
        Else
            If username.Text = "kasir" And password.Text = "123" Then
                minuman.Show()
                Me.Hide()
                username.Text = ""
                password.Text = ""
            ElseIf username.Text = "" And password.Text = "" Then
                MsgBox("Silahkan Masukan usernmae dan password!", vbCritical, "ERROR")
            ElseIf username.Text IsNot "kasir" And password.Text IsNot "123" Then
                MsgBox("Maaf username dan password salah!", vbCritical, "GAGAL")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isPasswordVisible Then
            password.PasswordChar = "*"
            isPasswordVisible = False
        Else
            password.PasswordChar = ControlChars.NullChar
            isPasswordVisible = True
        End If
    End Sub
End Class
