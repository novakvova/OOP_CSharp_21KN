namespace PropAndConstructor;

public class Person
{
    private string _id = null!;
    private string _firstName = null!;
    private string _lastName = null!;

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Phone { get; set; }

    //Визивається при створені класа.
    //Змінні набувають початкового значення
    //Конструктор по замовлюванню 
    public Person()
    {
        //GUID - рандомна величина, яка не може повторитися
        _id = Guid.NewGuid().ToString();
    }

    //Конструктор з параметрами
    public Person(string lastName, string firstname, string phone) : this() 
    {
        _lastName = lastName;
        _firstName = firstname;
        Phone = phone;
    }

    //Повертає значення _id
    public string Id { get { return _id; } }

    public void setFirstName(string firstName)
    { 
        _firstName = firstName; 
    }
    public string getFirstName()
    {
        return _firstName;
    }

    public override string ToString()
    {
        return $"{Id} -- {LastName} {_firstName} -> {Phone}";
    }
}
