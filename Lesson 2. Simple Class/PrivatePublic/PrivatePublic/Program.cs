// See https://aka.ms/new-console-template for more information
using PrivatePublic;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Cat мурчик = new Cat(); //Створив змінну для Сat - мурчик - об'єкт, екземпляр

Console.WriteLine("Вкажіть ім'я кота");
string name = Console.ReadLine();
мурчик.setName(name);
Console.WriteLine(мурчик.getName());

Console.WriteLine("Вкажіть вік котика");
int age = int.Parse(Console.ReadLine());
мурчик.setAge(age);
Console.WriteLine(мурчик.getAge());
//Console.WriteLine("Привіт козак!");
