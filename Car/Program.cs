public abstract class BaseCar
{
    public int Speed { get; set; }
    public string Name { get; set; }
    public int Wheels = 4;


    public BaseCar(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public abstract string Specs();

}

public class Supercar : BaseCar
{
    public Supercar(int speed, string name) : base(speed, name) { }
    public override string Specs()

    {
        return $"{Name} is speeding at {Speed}km/h.";

    }


}

public class SportsCar : BaseCar
{
    public SportsCar(int speed, string name) : base(speed, name) { }
    public override string Specs()
    {
        return $"{Name} is speeding at {Speed}km/h.";
    }
}


public class Program
{
    static void Main()
    {
        var ferrari = new Supercar(450, "Ferrari Pininfarina");

        Console.WriteLine(ferrari.Specs());
        Console.WriteLine($"{ferrari.Name} has {ferrari.Wheels} wheels");

        var civic = new SportsCar(293, "Honda Civic Type R");
        Console.WriteLine(civic.Specs());
        Console.WriteLine($"{civic.Name} has {civic.Wheels} wheels");

    }

}
