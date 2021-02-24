Imports MySql.Data.MySqlClient
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

    Public Shared Function QueryReader(cmdtext As String, col As Integer)
        Dim datalist As New ArrayList()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(cmdtext, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                For i As Integer = 0 To col - 1 Step 1
                    datalist.Add(reader(i))
                Next
            End While
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.ToString)
        End Try
        conn.Close()

        Return datalist
    End Function

    Public Shared Function ExecuteData(cmdtext As String) As Boolean
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

    Public Shared Function QueryGetone(cmdtext As String)
        'อยากได้ไร 1 อันเอาไป
        Dim data As Object
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(cmdtext, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                bonus = reader(0)
            End While
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.ToString)
        End Try
        conn.Close()

        Return data
    End Function

End Class
