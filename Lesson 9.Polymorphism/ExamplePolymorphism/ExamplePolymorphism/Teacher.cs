namespace ExamplePolymorphism;

public class Teacher : Worker
{
    //Посада
    private string _position;
    //Зарплата
    private decimal _salary;

    public Teacher()
    {
        _position = "No position";
        _salary = 0;
    }

    public override void ViewInfo()
    {
        base.ViewInfo();
        Console.WriteLine($"Position: {_position}");
        Console.WriteLine($"Salary: {_salary}");
    }

}
