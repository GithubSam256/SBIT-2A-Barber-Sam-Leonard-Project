Imports MySql.Data.MySqlClient

Module MySQLHelper

    ' Connection string to your MySQL database
    Public connStr As String = "server=localhost;user=root;password=;database=productdb;"
    Public conn As New MySqlConnection(connStr)

    ' Method to open the connection
    Public Sub OpenConnection()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("✅ Database connected successfully!", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("❌ Connection failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to close the connection
    Public Sub CloseConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("⚠️ Error closing connection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Module
