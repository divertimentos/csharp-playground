namespace BoardGame;

public class BoardGame
{
    static int CardsInThePile { get; set; } = 200;

    // public void DrawCards(int amount = 4)
    // {
    //     CardsInThePile -= amount;
    //     Console.WriteLine($"Player has drawn {amount} cards from the pile.");
    //     ShowCardsLeft();
    // }

    public static string ShowCardsLeft()
    {
        return $"\nThere are {CardsInThePile} cards left in the pile.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var boardGame = new BoardGame();
        var player = new Player("Alice");
        player.DrawCards(boardGame);
        player.DrawCards(boardGame, 10);
        Console.WriteLine($"Player {player.Name} has {player.Hand.Count} cards in hand.");
        Console.WriteLine(BoardGame.ShowCardsLeft());
    }
}