interface IAnimal
{
    int Paws { get; set; }
    string Name { get; set; }

    string MakeSound();
}

public class Cat : IAnimal
{

    public int Paws { get; set; }
    public string Name { get; set; }

    public Cat(int paws, string name)
    {
        Name = name;
        Paws = paws;

    }

    public string MakeSound()
    {
        return "Miau!";
    }
}

public class Program
{
    static void Main()
    {
        var fofinho = new Cat(paws: 4, name: "Fofinho");
        Console.WriteLine($"The cat is called {fofinho.Name}.");
        Console.WriteLine($"The cat has {fofinho.Paws} paws.");
        Console.WriteLine($"This is {fofinho.Name}'s sound: {fofinho.MakeSound()}");
    }
}
