Public Class codeexample
    Private balance As Decimal = 0D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text =
"Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
    Dim text As String = TextBox1.Text

    ' VB String Manipulation Methods
    Dim output1 As String = Microsoft.VisualBasic.Right(text, 5)
    Dim output2 As String = Microsoft.VisualBasic.RSet(text, 15)
    Dim output3 As String = Microsoft.VisualBasic.RTrim(text)
    Dim output4 As String = Microsoft.VisualBasic.Space(5)
    Dim output5() As String = Split(text, "" "")
    Dim output6 As Integer = Microsoft.VisualBasic.StrComp(text, ""hello"", vbTextCompare)
    Dim output7 As String = Microsoft.VisualBasic.StrConv(text, vbUpperCase)
    Dim output8 As String = Microsoft.VisualBasic.StrDup(3, text)
    Dim output9 As String = Microsoft.VisualBasic.StrReverse(text)
    Dim output10 As String = Microsoft.VisualBasic.Trim(text)
    Dim output11 As String = Microsoft.VisualBasic.UCase(text)

    ' Display results
    ListBox1.Items.Clear()
    ListBox1.Items.Add(""METHOD       || OUTPUT"")
    ListBox1.Items.Add(""---------------------------------------"")
    ListBox1.Items.Add(""Right()      || "" & output1)
    ListBox1.Items.Add(""RSet()       || '"" & output2 & ""'"")
    ListBox1.Items.Add(""RTrim()      || '"" & output3 & ""'"")
    ListBox1.Items.Add(""Space()      || '"" & output4 & ""' (5 spaces)"")
    ListBox1.Items.Add(""Split()      || First word: "" & output5(0))
    ListBox1.Items.Add(""StrComp()    || "" & output6)
    ListBox1.Items.Add(""StrConv()    || "" & output7)
    ListBox1.Items.Add(""StrDup()     || "" & output8)
    ListBox1.Items.Add(""StrReverse() || "" & output9)
    ListBox1.Items.Add(""Trim()       || '"" & output10 & ""'"")
    ListBox1.Items.Add(""UCase()      || "" & output11)
End Sub"

        ' Style settings
        RichTextBox1.ReadOnly = True
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Try to convert the input to an integer
            Dim number As Integer = Convert.ToInt32(TextBox1.Text)

            ' Perform a simple operation
            Dim result As Integer = 100 / number

            ' Output the result in the ListBox
            ListBox1.Items.Add("Result: " & result.ToString())

        Catch ex As FormatException
            ' Handles invalid input format (e.g., letters instead of numbers)
            ListBox1.Items.Add("Error: Please enter a valid number.")

        Catch ex As DivideByZeroException
            ' Handles division by zero
            ListBox1.Items.Add("Error: You cannot divide by zero.")

        Catch ex As Exception
            ' Handles any other unexpected errors
            ListBox1.Items.Add("An unexpected error occurred: " & ex.Message)

        Finally
            ' This code always runs, even if there was an error
            ListBox1.Items.Add("Process Completed.")
        End Try
    End Sub

End Class