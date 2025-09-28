Public Class interfacecode
    ' Define the Interface
    Public Interface IPrintable
        Sub Print()
    End Interface
    ' Implementing Class
    Public Class Document
        Implements IPrintable

        Public Sub Print() Implements IPrintable.Print
            ' When Print is called, show a new form with the message
            Dim f As New Form()
            f.Text = "Print Status"
            f.Size = New Size(300, 200)

            Dim lbl As New Label()
            lbl.Text = "Printing Document..."
            lbl.Font = New Font("Arial", 12, FontStyle.Bold)
            lbl.AutoSize = True
            lbl.Location = New Point(50, 70)

            f.Controls.Add(lbl)
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Sub
    End Class

    ' Button1 Click Event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a Document that implements IPrintable
        Dim doc As IPrintable = New Document()

        ' Call the Print() method → opens a new form
        doc.Print()
    End Sub
End Class
