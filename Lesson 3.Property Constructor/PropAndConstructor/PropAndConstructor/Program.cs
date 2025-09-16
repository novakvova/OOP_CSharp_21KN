// See https://aka.ms/new-console-template for more information
using PropAndConstructor;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Це конструктори!");

Person semen = new Person();

semen.setFirstName("Вітя");

semen.LastName = "Марков"; //визиваємо метод set

semen.Phone = "+38(098) 22 33 445";

Person ivanka = new Person("Борода","Люба", "+109 803 44 55");

//Console.WriteLine(semen.getFirstName());
//Console.WriteLine(semen.LastName); //визиваємо метод get
//Console.WriteLine(semen.Phone); //визиваємо метод get

Console.WriteLine(semen);
Console.WriteLine(ivanka);
