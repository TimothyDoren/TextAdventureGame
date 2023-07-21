Imports System

Module Program
    Sub Main(args As String())
        Console.Write("What is your name? ")
        Dim characterName As String = Console.ReadLine()
        Console.WriteLine($"Welcome to my game {characterName}!")
        Console.WriteLine("Please pick a class: ")
        Console.WriteLine(" Thief")
        Console.WriteLine(" Mage")
        Console.WriteLine(" Viking")
        Console.WriteLine(" Bandit")
        Console.WriteLine(" Bard")
        Dim classChoice As String = Console.ReadLine()
    End Sub
End Module
