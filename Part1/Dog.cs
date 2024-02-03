namespace AbstractClasses;

public class Dog: Animal
{
    public Dog(string _name, string _colour, int _age) : base(_name, _colour, _age) {}

    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}