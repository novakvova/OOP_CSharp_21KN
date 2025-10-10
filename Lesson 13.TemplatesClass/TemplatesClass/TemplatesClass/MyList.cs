using System.Collections;

namespace TemplatesClass;

//При створені даного класу буде використаний певний тип
//Це є шаблоний клас, бо він працює із певним шабоном (типом)
public class MyList<T> : IEnumerable
{
    //Зберігаю певний набір даних T
    private T[] _list;
    public MyList()
    {
        _list = new T[0];
    }
    public void AddItem(T item)
    {
        int n = _list.Length;
        T[] values = new T[n+1];
        for (int i = 0; i < n; i++)
        {
            values[i] = _list[i];
        }
        values[n] = item;
        _list = values;
    }

    public IEnumerator GetEnumerator()
    {
        return _list.GetEnumerator();
    }
}
