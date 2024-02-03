namespace AbstractClasses;

public interface IAnimal
{

    string GetName();
    string GetColour();
    int GetAge();
    
    void SetName(string _name);
    void SetColour(string _colour);
    void SetAge(int _age);
    
    void Eat();
    void Cry();
}