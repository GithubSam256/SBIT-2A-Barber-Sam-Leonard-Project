Public Class example1
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
        Dim text As String = TextBox1.Text

        ' VB Built-in Functions
        Dim output1 As Integer = Asc(text)
        Dim output2 As Integer = AscW(text)
        Dim output3 As Char = Chr(65)
        Dim output4 As Char = ChrW(8369) ' ₱ symbol
        Dim words() As String = {"apple", "banana", "cherry", "avocado"}
        Dim output5() As String = Filter(words, "a")
        Dim output6 As String = Format(1234.567, "#,##0.00")
        Dim output7 As String = FormatCurrency(1234.567)
        Dim output8 As String = FormatDateTime(Now, DateFormat.LongDate)
        Dim output9 As String = FormatNumber(1234.567)
        Dim output10 As String = FormatPercent(0.85)

        ' Display results
        ListBox1.Items.Clear()
        ListBox1.Items.Add("METHOD              || OUTPUT")
        ListBox1.Items.Add("-------------------------------------------")
        ListBox1.Items.Add("Asc()               || " & output1 & "   (Converted text)")
        ListBox1.Items.Add("AscW()              || " & output2 & "   (Converted text)")
        ListBox1.Items.Add("Chr()               || " & output3 & "  ")
        ListBox1.Items.Add("ChrW()              || " & output4 & "  ")
        ListBox1.Items.Add("Filter()            || " & String.Join(", ", output5) & "  ")
        ListBox1.Items.Add("Format()            || " & output6 & "  ")
        ListBox1.Items.Add("FormatCurrency()    || " & output7 & "   ")
        ListBox1.Items.Add("FormatDateTime()    || " & output8 & "  ")
        ListBox1.Items.Add("FormatNumber()      || " & output9 & "  ")
        ListBox1.Items.Add("FormatPercent()     || " & output10 & "  ")
    End Sub
End Class