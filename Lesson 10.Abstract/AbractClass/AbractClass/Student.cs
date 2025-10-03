using Bogus;

namespace AbractClass;

public class Student : Person
{
    /// <summary>
    /// Дата вступу
    /// </summary>
    private DateTime _entryDate;
    /// <summary>
    /// Група у студента
    /// </summary>
    private string _group;

    public Student()
    {
        _entryDate = DateTime.Now;
        _group = "No Group";
    }

    public Student(bool isRandom=false) 
        :base(isRandom)
    {
        Faker faker = new Faker();
        _group = "Group " + faker.Random.Int(1, 5);
    }

    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Дата вступу: " + strDate);
        Console.WriteLine("Група: " + _group);
        Console.ForegroundColor= ConsoleColor.White;
    }
}
