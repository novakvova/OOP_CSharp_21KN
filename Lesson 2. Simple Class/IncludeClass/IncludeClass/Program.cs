// See https://aka.ms/new-console-template for more information
using IncludeClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт! Класний дощ.");

Animal cat = new Animal();
cat.SetName("Барсік");
cat.SetAge(4);
cat.SetPoroda("Дворовий рижий");

Animal dog = new Animal();
dog.SetName("Петрович");
dog.SetAge(6);
dog.SetPoroda("Пітбуль");

Prytulok troy = new Prytulok();
troy.AddAnimal(cat);
troy.AddAnimal(dog);

Console.WriteLine("---Тварини у притулку---");
troy.ShowAnimals();

//Console.WriteLine($"{cat.GetName()}\t{cat.GetAge()}\t{cat.GetPoroda()}");
//ToString()
//Console.WriteLine(cat);
//Console.WriteLine(cat.ToString());
