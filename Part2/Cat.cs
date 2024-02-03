namespace AbstractClasses;

public class Cat: IAnimal
{
    private string name;
    private string colour;
    private int age;
    
    
    
    public void SetName(string _name)
    {
        this.name = _name;
    }

    public void SetColour(string _colour)
    {
        this.colour = _colour;
    }
    
    public void SetAge(int _age)
    {
        this.age = _age;
    }
    
    
    
    public string GetName()
    {
        return this.name;
    }

    public string GetColour()
    {
        return this.colour;
    }

    public int GetAge()
    {
        return this.age;
    }
    
    

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public void Cry()
    {
        Console.WriteLine("Meow!");
    }
}