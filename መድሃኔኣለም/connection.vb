Imports System.Data.SqlClient
Public Class connection
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Function connect(ByVal x As String) As Integer
        Dim n As Integer
        n = 0
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.ConnectionString = "Data Source=ABRYEE-PC;Initial Catalog=MedhanieAlem;Integrated Security=True"
                con.Open()
                cmd.CommandText = x
                cmd.Connection = con
                n = 1
        Catch ex As Exception
            n = 0
        End Try
        Return n
    End Function
End Class
