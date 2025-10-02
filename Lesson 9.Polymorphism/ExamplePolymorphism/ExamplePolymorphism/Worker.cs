namespace ExamplePolymorphism;

public class Worker
{
    private string _id;
    private string _name;
    private string _description;
    private ushort _age; //ushort - додатнє мальньке число
    //ctor - троя
    public Worker()
    {
        _id = Guid.NewGuid().ToString();
        _name = "No name";
        _description = "No description";
        _age = 0;
    }
    //Цей клас можна перевизначати і буде працювати
    //пізнє зв'язування
    public virtual void ViewInfo()
    {
        Console.WriteLine($"Id: {_id}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Age: {_age}");
    }
}
