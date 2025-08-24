interface IAnimal {
  string MakeSound();
}

public class Cat : IAnimal
{

    public int Paws;
    public string Name;

    public Cat(int paws, string name)
    {
        Paws = paws;
        Name = name;

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
        var dante = new Cat(paws: 4, name: "Dante");
        Console.WriteLine($"The cat is called {dante.Name}.");
        Console.WriteLine($"The cat has {dante.Paws} paws.");

    }
}
