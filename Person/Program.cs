class Person
{

    private string Reverser(string sentence)
    {
        char[] tobeReversed = sentence.ToCharArray();
        Array.Reverse(tobeReversed);
        return new string(tobeReversed);

    }

    private string FullName(string firstName, string lastName)
    {
        return $"{firstName}{lastName}";
    }


    public string Greet(string name, bool isReversed = false)
    {
        if (isReversed)
        {
            var reversedName = Reverser(name);

            return $"Hello! My name is {reversedName}.";
        }

        return $"Hello! My name is {name}.";
    }



}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();

        Console.WriteLine(person.Greet("Anakin", true));
    }
}
