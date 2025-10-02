namespace InhritanceDetails;

public class Person
{
    //Guid - унікальиий ідентифікатор
    private readonly Guid _id;
    private string _name = "";
    public Person()
    {
        _id = Guid.NewGuid(); //Створюємо унікальний id
    }
}
