class BoardGame
{
    static int CardsInThePile { get; set; } = 200;

    public BoardGame()
    {
        CardsInThePile -= 4;
    }

    public static string ShowCardsLeft()
    {
        return $"There are {CardsInThePile} cards left in the pile.";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var luiza = new BoardGame();
            var chomsky = new BoardGame();
            Console.WriteLine(BoardGame.ShowCardsLeft());
        }
    }
}
