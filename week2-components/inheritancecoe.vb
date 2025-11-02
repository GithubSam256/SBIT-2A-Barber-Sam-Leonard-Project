Public Class framework
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text.Trim().ToLower()
        Dim chosenAnimal As Animal = Nothing
        Select Case input
            Case "animal"
                chosenAnimal = New Animal()
            Case "dog"
                chosenAnimal = New Dog()
            Case "cat"
                chosenAnimal = New Cat()
            Case "sheep"
                chosenAnimal = New Sheep()
            Case Else
                MessageBox.Show("Invalid choice. Please type: Animal, Cat, Dog, or Sheep.")
                Exit Sub
        End Select
        ListBox1.Items.Clear()
        ListBox1.Items.Add(chosenAnimal.Speak())
    End Sub
    Private Sub inheritancecoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Animal
    Public Overridable Function Speak() As String
        Return "Animal speaks"
    End Function
End Class
Public Class Dog
    Inherits Animal
    Public Overrides Function Speak() As String
        Return "Dog barks"
    End Function
End Class


Public Class Cat
    Inherits Animal
    Public Overrides Function Speak() As String
        Return "Cat meows"
    End Function
End Class

Public Class Sheep
    Inherits Animal
    Public Overrides Function Speak() As String
        Return "Sheep says Baa Baa"
    End Function
End Class
