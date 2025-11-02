Imports MySql.Data.MySqlClient

Public Class invsystem

    Private Sub invsystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open database connection
        OpenConnection()

        ' ✅ Load data from the "sales" table into DataGridView1
        LoadData("SELECT * FROM sales", DataGridView1)
        LoadData("SELECT * FROM products", DataGridView2)
        LoadData("SELECT * FROM shoes", DataGridView3)
        LoadData("SELECT * FROM food", DataGridView4)

    End Sub

    ' ✅ Function to load data into DataGridView
    Private Sub LoadData(query As String, datagridviewer As DataGridView)
        Try
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            datagridviewer.DataSource = table

        Catch ex As Exception
            MessageBox.Show("❌ Error loading data: " & ex.Message)
        Finally
            ' Always close connection after use
            CloseConnection()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData("SELECT * FROM sales", DataGridView1)
        LoadData("SELECT * FROM products", DataGridView2)
        LoadData("SELECT * FROM shoes", DataGridView3)
        LoadData("SELECT * FROM food", DataGridView4)
    End Sub
End Class

'connection
'check the connection status
'use the connection
'create a Function To load data  
'Try Catch has query And connection
'Get the data into adapter
'insert it into table
'show it To datagridview that you drag And drop
'use the function

