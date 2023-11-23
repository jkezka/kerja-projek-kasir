Imports System.Data.Odbc

Module Module1

    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public CMd As OdbcCommand
    Public Rd As OdbcDataReader

    Public MyDB As String
    Public Sub Konekdb()

        Try

            Conn = New OdbcConnection("DSN=kpkasir;MultipleActiveResultSets=True")

            If Conn.State = ConnectionState.Closed Then

                Conn.Open()
                'MsgBox("Koneksi ke database berhasil", vbInformation, "Koneksi sukses")

            End If

        Catch ex As Exception

            MsgBox("Koneksi ke database gagal", vbCritical, "Koneksi Gagal")

        End Try

    End Sub

End Module
