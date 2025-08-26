namespace BoardGame;

using System.Collections.Generic;

public class Player
{
    public string Name { get; }
    public List<int> Hand { get; } = new();

    public Player(string name)
    {
        Name = name;
    }

    public void DrawCards(BoardGame boardGame, int amount = 4)
    {
        Hand.AddRange(Enumerable.Repeat(1, amount)); // Example: Add drawn cards to hand
    }
}