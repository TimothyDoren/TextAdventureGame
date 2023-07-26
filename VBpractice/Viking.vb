Public Class Viking
    Inherits Character

    Public Sub New(characterName As String)
        MyBase.New(characterName)
        Name = characterName
        Health = 7
        Attack = 8
        Magic = 2
        Charisma = 4
        Luck = 6
        Strength = 6
    End Sub

    Public Overrides Sub ShowStats()
        Console.Write("Health: ")
        Console.Write(Health)
        Console.WriteLine("")
        Console.Write("Attack: ")
        Console.Write(Attack)
        Console.WriteLine("")
        Console.Write("Magic: ")
        Console.Write(Magic)
        Console.WriteLine("")
        Console.Write("Charisma: ")
        Console.Write(Charisma)
        Console.WriteLine("")
        Console.Write("Luck: ")
        Console.Write(Luck)
        Console.WriteLine("")
        Console.Write("Strength: ")
        Console.Write(Strength)
        Console.WriteLine("")
    End Sub

    Public Overrides Sub SpecialAbility()
        Throw New NotImplementedException()
    End Sub
End Class
