// See https://aka.ms/new-console-template for more information
using System.Text;
using TemplatesClass;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт команда!");

//Масив, який зберігає певний шаблон - тип даних
//List<string> list = new List<string>();
//list.Add("Вова");
//list.Add("Cтепан");
//list.Add("Марина");
//foreach (string item in list)
//{
//    string str = string.Format("{0}\t", item);
//    Console.WriteLine(str);
//}

//MyList<string> myList = new MyList<string>();
//myList.AddItem("Сало");
//myList.AddItem("Цибуля");
//myList.AddItem("Хліб");

//foreach (var item in myList)
//{
//    Console.WriteLine("{0}\t", item);
//}

MyList<People> commanda  = new MyList<People>();

commanda.AddItem(new People());
commanda.AddItem(new People());

foreach (var item in commanda)
{
    Console.WriteLine(item);
}