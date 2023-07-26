﻿Public Class Bard
    Inherits Character

    Public Sub New(characterName As String)
        MyBase.New(characterName)
        Name = characterName
        Health = 5
        Attack = 4
        Magic = 4
        Charisma = 9
        Luck = 9
        Strength = 4
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
