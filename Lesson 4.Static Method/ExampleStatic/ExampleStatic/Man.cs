using static Bogus.DataSets.Name;

namespace ExampleStatic;

public class Man
{
    private string _firstName;

    //public Gender Gender { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    private string _lastName;

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age { get; set; }

    //Статичне поле для зберіження кількості 
    //створених об'єктів(екземплярів)
    private static int _counter = 0;

    //ctor - створити конструкто по замовчуванню
    public Man()
    {
        Man._counter++;
    }

    /// <summary>
    /// Ми зробили конструктор з параметрами, 
    /// який викликає конструктор по замовчуванню
    /// </summary>
    /// <param name="firstName">Ім'я</param>
    /// <param name="lastName">Прізвище</param>
    /// <param name="age">Вік</param>
    public Man(string firstName, string lastName, int age)
        : this() //виклик конструктора по замовчуванню
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public static void Info()
    {
        Console.WriteLine("На клас для роботи Man :)");
    }

    public static int GetCounter()
    {
        return _counter;
    }
    
    public override string ToString()
    {
        return $"Прізвище: {LastName}, Ім'я: {FirstName}, Вік: {Age}";
    }

}
