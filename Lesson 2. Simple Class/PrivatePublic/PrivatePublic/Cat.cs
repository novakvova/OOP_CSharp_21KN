namespace PrivatePublic;

class Cat
{
    /// <summary>
    /// Назва кота
    /// </summary>
    private string name;
    /// <summary>
    /// Вік
    /// </summary>
    private int age;  //не хочу давати public
    /// <summary>
    /// Порода кота
    /// </summary>
    private string breed;
    //this - звертаюся до даного класу
    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ім'я котима не може бути постим (:(:(:(:");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        this.name = name;
    }
    public string getName() { return name; }

    public void setAge(int age) 
    {
        if (age < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Даний коти - ще не родився (:");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }    
        this.age = age; 
    }
    public int getAge() { return age; }


}
