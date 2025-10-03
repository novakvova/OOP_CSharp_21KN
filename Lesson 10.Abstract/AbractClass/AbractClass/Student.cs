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

    public override void ViewInfo()
    {
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Дата вступу: " + strDate);
        Console.WriteLine("Група: " + _group);
    }
}
