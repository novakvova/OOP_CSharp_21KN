namespace TemplatesClass;

public class People
{
    private string _name;
    private int _age;
    private string _phone;

    public People()
    {
        _name = "No name";
        _age = 18;
        _phone = "000-000-00-00";
    }

    public override string ToString()
    {
        string str = string.Format("{0}\t{1}\t{2}", _name, _age, _phone);
        return str;
    }
}
