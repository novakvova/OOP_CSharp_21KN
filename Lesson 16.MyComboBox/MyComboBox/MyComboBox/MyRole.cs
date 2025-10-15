using System.CodeDom;

namespace MyComboBox;

public class MyRole
{
    private int _id;
    private string _name;

    public MyRole()
    {
        this._id = 0;
        this._name=String.Empty;
    }
    public MyRole(int id, string name)
    {
        this._id=id;
        this._name = name;
    }
    public override string ToString()
    {
        return _name;
    }
}
