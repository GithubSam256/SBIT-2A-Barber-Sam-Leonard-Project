Public Class encapscode
    Private balance As Decimal = 0D
    Private Sub encapscode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Balance: " & balance.ToString("C"))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal

        If Decimal.TryParse(TextBox1.Text, amount) AndAlso amount > 0 Then
            balance += amount
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Balance: " & balance.ToString("C"))
            ListBox1.Items.Add("Deposited: " & amount.ToString("C"))
            TextBox1.Clear()
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount As Decimal

        If Decimal.TryParse(TextBox1.Text, amount) AndAlso amount > 0 Then
            If balance >= amount Then
                balance -= amount
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Balance: " & balance.ToString("C"))
                ListBox1.Items.Add("Withdraw: " & amount.ToString("C"))
                TextBox1.Clear()
            Else
                MessageBox.Show("Insufficient balance.")
            End If
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub
End Class
