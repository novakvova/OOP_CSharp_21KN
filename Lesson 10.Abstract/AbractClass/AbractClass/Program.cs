// See https://aka.ms/new-console-template for more information

using AbractClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
//Console.WriteLine("Добрий ранок!");

/*
//Не можна створювати об'єкти абстрактних класів
Person person = new Teacher(); //new Student();
//Person teacher = new Teacher();

//as і is
if(person is Student)
{
    Console.WriteLine("------Student------");
    person.ViewInfo();
}
else if(person is Teacher)
{
    Console.WriteLine("------Teacher------");
    person.ViewInfo();
}
*/

PersonProvider pp = new PersonProvider();
pp.ListGeneration(12);
Console.WriteLine("---------Items View---------");
pp.ShowAll();
