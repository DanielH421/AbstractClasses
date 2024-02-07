namespace AbstractClasses;

public class Dog: Animal
{
    public Dog(string _name, string _colour, int _age) : base(_name, _colour, _age) {}

    // override the eat function, since dogs eat meat
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}