namespace MyComparable;

public class Animal : IComparable<Animal>
{
    private string _name;
    private ushort _age;
    private Sex _sex;

    public Animal()
    {
        _name = "No name";
        _age = 0;
        _sex = Sex.Unknown;
    }

    public Animal(string name, 
        ushort age, Sex sex)
    {
        _name = name;
        _age = age;
        _sex = sex;
    }

    public int CompareTo(Animal? other)
    {
        if (other == null) return 1;
        //Порівняння об'єктів буду проводити по іменах
        return _name.CompareTo(other._name);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        var other = obj as Animal;
        return this._name.Equals(other?._name);
    }

    public override string ToString()
    {
        string sex = "Не значена";
        if (_sex == Sex.Female)
            sex = "Дівчинка";
        if (_sex == Sex.Male)
            sex = "Хлопчик";

        return $"{_name}\t{_age}\t{sex}";
    }
}
