Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql

Module Module1
    Public cn As New NpgsqlConnection
    Public cmd As NpgsqlCommand
    Public dr As NpgsqlDataReader
    Public sql As String

    Public Sub openCon()
        cn.ConnectionString = "Server = localhost; Port = 5432; User ID = postgres; Password = admin; Database=employeeDB"

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

    End Sub

End Module
