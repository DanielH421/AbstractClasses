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
        
        Console.WriteLine("");
        
        PrintAnimalInfo(cat);
        cat.Eat();
    }



    // Based on the given type of animal, return the proper object.
    public static Animal GetUserAnimal(string type)
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
            return new Cat(name, colour, age);
        }
        else
        {
            return new Dog(name, colour, age);
        }
    }


    // Though the Animal object has a ToString method that is exactly the same. The assignment calls for the usage of getters.
    public static void PrintAnimalInfo(Animal animal)
    {
        Console.WriteLine($"Name: {animal.Name}, Colour: {animal.Colour}, Age: {animal.Age}");
    }
    
}
