// See https://aka.ms/new-console-template for more information

using AbractClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Добрий ранок!");

//Не можна створювати об'єкти абстрактних класів
Person person = new Student();


person.ViewInfo();
