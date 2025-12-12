namespace TaskOne;

//virtual
//ovveride
public class Dog : Object
{
    private string name;
    private int age;
    public Dog() 
    {
        name="no name";
        age=2;
    }

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //
    public override string ToString()
    {
        return $"{name}\t{age}";
    }
}
