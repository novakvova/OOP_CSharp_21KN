// See https://aka.ms/new-console-template for more information
using MyComparable;
using System.Collections.Generic;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
//Console.WriteLine("Привіт козаки!");

//string mykola = "Микола Володимирович";
//string vova = "Володимир Миколайович";

////strcmp() ...

//Console.WriteLine("vova.CompareTo(mykola) {0}", 
//    vova.CompareTo(mykola));

//Console.WriteLine("mykola.CompareTo(vova) {0}",
//    mykola.CompareTo(vova));

//if (vova > mykola)
//{
//    Console.WriteLine("vova > mykola");
//}

//HashSet<string> dishes = new HashSet<string>();
//dishes.Add("Часник");
//dishes.Add("Цибуля");
//dishes.Add("Ананас");
//dishes.Add("Ананас");

//foreach (string s in dishes)
//{
//    Console.WriteLine("{0}\t", s);
//}

HashSet<Animal> animals = new HashSet<Animal>();

animals.Add(new Animal("Бобік", 1, Sex.Male));
animals.Add(new Animal("Спартак", 2, Sex.Male));
animals.Add(new Animal("Спартак", 2, Sex.Male));

foreach (var animal in animals)
{
    Console.WriteLine(animal);
}