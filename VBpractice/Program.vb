Imports System

Module Program
    Sub Main(args As String())
        Console.Write("What is your name? ")
        Dim characterName As String = Console.ReadLine()
        Console.WriteLine($"Welcome to my game {characterName}!")
        Console.WriteLine("Please pick a class: ")
        Console.WriteLine("1. Thief")
        Console.WriteLine("2. Mage")
        Console.WriteLine("3. Viking")
        Console.WriteLine("4. Bandit")
        Console.WriteLine("5. Bard")
        Dim classChoice As Integer = Integer.Parse(Console.ReadLine())
        Dim player As Character = Nothing
        Select Case classChoice
            Case 1
                player = New Thief(characterName)
        End Select
        Console.WriteLine("Current Stats: ")
        player.ShowStats()
    End Sub
End Module
