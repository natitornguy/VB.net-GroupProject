Imports MySql.Data.MySqlClient
'ทำ Try Catch ด้วย
Public Class ConnectDB
    Private Shared conn As MySqlConnection = New MySqlConnection
    Public Sub New()
        Dim conn As MySqlConnection = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=admin;database=hrdb"
        Try
            conn.Open()
            Dim Sql As String = "SELECT * FROM holidays"
            Dim cmd As MySqlCommand = New MySqlCommand(Sql, conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While (rdr.Read())
                Debug.WriteLine(rdr(0) & "--" & rdr(1) & "--" & rdr(2))
            End While
            rdr.Close()
            MessageBox.Show("Connected")
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.ToString)
        End Try
    End Sub
    Public Shared Function QueryAdapter(cmdtext As String) 'As 
        conn.ConnectionString = "server=localhost;userid=root;password=admin;database=hrdb"
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "leave")

        conn.Close()
        Return data
    End Function

    Public Shared Function QueryReader(cmdtext As String, rangecol As Integer)
        '' rangecol = จำนวน colum ที่ select ใน sql
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim datalist As New ArrayList
        'Debug.WriteLine(rangecol)
        While reader.Read
            For i As Integer = 0 To rangecol - 1 Step 1
                'Debug.WriteLine(reader(i))
                datalist.Add(reader(i))
            Next
        End While
        conn.Close()

        Return datalist
    End Function

    Public Shared Function editData(cmdtext As String)
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = cmdtext
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("Error : " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        conn.Close()
        Return True
    End Function
End Class
