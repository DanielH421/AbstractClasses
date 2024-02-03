namespace AbstractClasses;

public interface IAnimal
{
    // Sets the name of the animal.
    void SetName(string _name);
    
    // Sets the colour of the animal.
    void SetColour(string _colour);
    
    // Sets the age of the animal.
    void SetAge(int _age);

    
    // Returns the name of the animal.
    string GetName();
    
    // Returns the colour of the animal.
    string GetColour();
    
    // Returns the age of the animal.
    int GetAge();


    // Represents eating behaviour of the animal.
    void Eat();
    
    // Represents whatever noise the animal makes.
    void Cry();
}