// See https://aka.ms/new-console-template for more information
using System.Text;
//Тут знаходиться набір класів для роботи із колекціями
using System.Collections;
using ExampleCollection;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
//Може зберігати однаковий тип даних
Int32[] myArray = { 23, 45, 78 }; 
foreach (int i in myArray)
{
    Console.Write("{0}\t", i);
}
Console.WriteLine();
//Він не є generic - він не є шаблоний
ArrayList myArrayList = new ArrayList();
myArrayList.Add(23);
myArrayList.Add("Білочка");
myArrayList.Add(true);
myArrayList.Add(3.56);

foreach (var item in myArrayList)
{
    Console.Write("{0}\t",item);
}
Console.WriteLine();

//CLS - 
//CLR - Common Language Runtime - єдине середвище виконання
object myObject = "Hello my friends";
Console.WriteLine(myObject);

Console.WriteLine("-------My Array Custom-------");

MyGeneric stepan = new MyGeneric();

stepan.Add("Альона");
stepan.Add("Мальвіна");
stepan.Add(18);
stepan.Add(22);

stepan.ViewItems();

int index = stepan.SearchIndex(18);
Console.WriteLine("Search index = " + index);

