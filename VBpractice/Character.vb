Public MustInherit Class Character
    Public Property Name As String
    Public Property Health As Integer
    Public Property Attack As Integer
    Public Property Magic As Integer
    Public Property Charisma As Integer
    Public Property Luck As Integer
    Public Property Strength As Integer

    Public Sub New(characterName As String)
        Name = characterName
    End Sub

    Public MustOverride Sub ShowStats()
    Public MustOverride Sub SpecialAbility()


End Class
