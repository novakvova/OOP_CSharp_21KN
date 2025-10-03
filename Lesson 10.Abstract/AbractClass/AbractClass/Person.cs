namespace AbractClass;

public abstract class Person
{
    //_ - позначка для програміста, що це приватна змінна
    private string _id = String.Empty;
    private string _name = String.Empty;
    private string _phone = String.Empty;

    //Конструктор захищений - можна використовувати у 
    //дочірньому класі
    protected Person()
    {
        _id = Guid.NewGuid().ToString();
        _name = "No name";
        _phone = "+38(000) 00 00 000";
    }

    // virtual
    public virtual void ViewInfo()
    {
        Console.WriteLine("Id: "+_id);
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Phone: " + _phone);
    }
}
