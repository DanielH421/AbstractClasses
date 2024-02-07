namespace AbstractClasses;

public class Cat: Animal
{
    public Cat(string _name, string _colour, int _age) : base(_name, _colour, _age) {}

    // override the eat function since cats eat mice
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}