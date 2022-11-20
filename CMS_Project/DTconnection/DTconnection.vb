Imports MySql.Data.MySqlClient
Public Class DTconnection
    'Dim connect As New MySqlConnection("server='containers-us-west-95.railway.app';port=5999;uid='root';pwd='RZECLgj1qnH49foeAhb7';database='railway'")
    Dim connect As New MySqlConnection("server='localhost';uid='root';pwd='yxdb';database='cmsdbx'")
    Public Function open() As MySqlConnection
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
    Public Function close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class