﻿Imports MySql.Data.MySqlClient
'ทำ Try Catch ด้วย
Public Class ConnectDB

    Private Shared conString As String = "server=localhost;userid=root;password=admin;database=hrdb"
    Private Shared conn = New MySqlConnection(conString)

    Public Shared Function QueryAdapter(cmdtext As String) As DataSet
        Dim data As New DataSet()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(cmdtext, conn)
            Dim adp As New MySqlDataAdapter(cmd)
            adp.Fill(data, "data")
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.ToString)
        End Try
        conn.Close()
        Return data
    End Function

    Public Shared Function QueryReader(cmdtext As String, rangecol As Integer)
        '' rangecol = จำนวน colum ที่ select ใน sql
        'conn.Open()
        'Dim cmd As New SQLiteCommand
        'cmd.Connection = conn
        'cmd.CommandText = cmdtext
        'Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        'Dim datalist As New ArrayList
        ''Debug.WriteLine(rangecol)
        'While reader.Read
        '    For i As Integer = 0 To rangecol - 1 Step 1
        '        'Debug.WriteLine(reader(i))
        '        datalist.Add(reader(i))
        '    Next
        'End While
        'conn.Close()

        'Return datalist
    End Function

    Public Shared Function editData(cmdtext As String)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(cmdtext, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        conn.Close()
        Return True
    End Function

    Public Shared Function QueryAllDepartmentName(cmdtext As String, col As Integer)
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = cmdtext
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim datalist As New ArrayList
        'Debug.WriteLine(rangecol)
        While reader.Read
            datalist.Add(reader(1))
        End While
        connection.Close()

        Return datalist
    End Function

    Public Shared Function QueryDepartment(cmdtext As String)
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = cmdtext
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim dep_name As String
        'Debug.WriteLine(rangecol)
        While reader.Read
            dep_name = reader(0)
        End While
        connection.Close()

        Return dep_name
    End Function
End Class
