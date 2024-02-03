namespace AbstractClasses;

public abstract class Animal
{
    private string name;
    private string colour;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value;  }
    }

    public string Colour
    {
        get { return colour; }
        set { colour = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public Animal(string _name, string _colour, int _age)
    {
        this.name = _name;
        this.age = _age;
        this.colour = _colour;
    }


    public abstract void Eat();


    public string ToString()
    {
        return $"Name: {this.name}, Colour: {this.colour},Age: {this.age}";
    }
    
}