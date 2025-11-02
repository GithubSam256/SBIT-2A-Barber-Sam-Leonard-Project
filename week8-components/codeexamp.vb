Public Class codeexamp

    ' Button1 → Change panel color using ColorDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim colorDialog As New ColorDialog()

            If colorDialog.ShowDialog() = DialogResult.OK Then
                Panel1.BackColor = colorDialog.Color
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while changing the panel color: " & ex.Message)
        End Try
    End Sub

    ' Button2 → Change label font using FontDialog
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim fontDialog As New FontDialog()

            If fontDialog.ShowDialog() = DialogResult.OK Then
                Label2.Font = fontDialog.Font
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while changing the label font: " & ex.Message)
        End Try
    End Sub

    ' Button3 → Change PictureBox image using OpenFileDialog
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the image: " & ex.Message)
        End Try
    End Sub
End Class
