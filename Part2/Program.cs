namespace AbstractClasses;
public class Program
{
        
    public static void Main(string[] args)
    { 
        // Create the animal objects. cast to the proper type as well.
        Dog dog = (Dog) GetUserAnimal("dog");
        Cat cat = (Cat) GetUserAnimal("cat");
        
        Console.WriteLine("\n");
        
        PrintAnimalInfo(dog);
        dog.Eat();
        dog.Cry();
        
        Console.WriteLine("");
        
        PrintAnimalInfo(cat);
        cat.Eat();
        cat.Cry();
    }
        
    
    // Based on the given type of animal, return the proper object.
    public static IAnimal GetUserAnimal(string type)
    {
        string name;
        string colour;
        int age;
        
        Console.Write($"Enter {type} name: ");
        name = Console.ReadLine();
        Console.Write($"Enter {type} colour: ");
        colour = Console.ReadLine();
        Console.Write($"Enter {type} age: ");
        age = int.Parse(Console.ReadLine());

        if (type == "cat")
        {
            Cat cat = new Cat();
            cat.SetName(name);
            cat.SetColour(colour);
            cat.SetAge(age);
            return cat;
        }
        else
        {
            Dog dog = new Dog();
            dog.SetName(name);
            dog.SetColour(colour);
            dog.SetAge(age);
            return dog;
        }

        // If this gets returned. Something went seriously wrong
        return null;
    }


    // Though the Animal object has a ToString method that is exactly the same. The assignment calls for the usage of getters.
    public static void PrintAnimalInfo(IAnimal animal)
    {
        Console.WriteLine($"Name: {animal.GetName()}, Colour: {animal.GetColour()}, Age: {animal.GetAge()}");
    }
    
}