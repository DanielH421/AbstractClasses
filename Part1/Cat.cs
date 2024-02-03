namespace AbstractClasses;

public class Cat: Animal
{
    public Cat(string _name, string _colour, int _age) : base(_name, _colour, _age) {}

    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}