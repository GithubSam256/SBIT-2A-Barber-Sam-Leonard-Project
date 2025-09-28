Public Class polymorcode
    Public Class Animal
        Protected output As ListBox

        Public Sub New(lst As ListBox)
            output = lst
        End Sub

        Public Overridable Sub Speak()
            output.Items.Add("Animal makes a sound")
        End Sub
    End Class
    Public Class Bird
        Inherits Animal

        Public Sub New(lst As ListBox)
            MyBase.New(lst)
        End Sub

        Public Overrides Sub Speak()
            output.Items.Add("Bird says: Tweet Tweet")
        End Sub
    End Class
    Public Class Lion
        Inherits Animal
        Public Sub New(lst As ListBox)
            MyBase.New(lst)
        End Sub
        Public Overrides Sub Speak()
            output.Items.Add("Lion says: Roar")
        End Sub
    End Class
    Public Class Pig
        Inherits Animal
        Public Sub New(lst As ListBox)
            MyBase.New(lst)
        End Sub
        Public Overrides Sub Speak()
            output.Items.Add("Pig says: Oink")
        End Sub
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim input As String = TextBox1.Text.Trim().ToLower()
        Dim chosenAnimal As Animal = Nothing

        Select Case input
            Case "animal"
                chosenAnimal = New Animal(ListBox1)
            Case "bird"
                chosenAnimal = New Bird(ListBox1)
            Case "lion"
                chosenAnimal = New Lion(ListBox1)
            Case "pig"
                chosenAnimal = New Pig(ListBox1)
            Case Else
                ListBox1.Items.Add("Invalid choice. Please type: animal, bird, lion, or pig.")
        End Select

        If chosenAnimal IsNot Nothing Then
            chosenAnimal.Speak()
        End If
    End Sub

End Class
